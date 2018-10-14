using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // keep track of where gravity should point - for in editor shenanigans
    public LevelEntity levelEntity;

    public Transform rodTransform;
    public float rotateSpeed = 100f;
    public float closeDistance = 0.1f;
    public float jumpSpeed = 8f;

    public bool flipping = false;
    private bool jumping = false;

    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private float oldGravityScale;
    private int score = 0;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        GetComponent<Animator>().speed = levelEntity.levelSpeed / 4;
	}

    void Update ()
    {
        if (Input.GetButtonDown("Flip") && !flipping && !jumping) {
            Flip();
        }
        Debug.Log(rb.velocity.ToString());
        if (Input.GetButtonDown("Jump") && !jumping && !flipping) {
            Debug.Log("Jump!");
            Jump();
        }
    }

    // FixedUpdate is called once per physics step
    void FixedUpdate () {
        if (flipping) {
            // rotate the rod
            rodTransform.Rotate(new Vector3(rotateSpeed, 0, 0) * Time.fixedDeltaTime, Space.World);
            if ( Mathf.Abs(rodTransform.rotation.eulerAngles.x) < closeDistance) {
                // stop flipping
                flipping = false;
                transform.SetParent(null);
                rb.gravityScale = -oldGravityScale;
            }
        }

        jumping = !(Mathf.Abs(rb.velocity.y) > float.Epsilon);

        // colliding with an obstacle
        Collider2D[] results = new Collider2D[2];
        ContactFilter2D cf = new ContactFilter2D();
        cf.SetLayerMask(LayerMask.GetMask("Obstacle"));
        if (bc.OverlapCollider(cf, results) > 0) {
            levelEntity.active = false;
            levelEntity.EndLevel(-1);
        }
        cf.SetLayerMask(LayerMask.GetMask("EndOfLevel"));
        if (bc.OverlapCollider(cf, results) > 0) {
            levelEntity.EndLevel(score);
        }
	}

    public void Flip () {
        // flip the player from the top to the bottom or vice versa
        flipping = true;
        oldGravityScale = rb.gravityScale;
        rb.gravityScale = 0;
        transform.SetParent(rodTransform);
        score++;
    }

    public void Jump () {
        rb.velocity = Vector2.up * rb.gravityScale * jumpSpeed;
    }
}
