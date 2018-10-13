using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // keep track of where gravity should point - for in editor shenanigans
    public bool isUp = true;
    public bool isDown = false;

    public Transform rodTransform;
    public float rotateSpeed = 300f;
    public float closeDistance = float.Epsilon;

    private bool flipping = false;

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void Update ()
    {
        if (Input.GetButtonDown("Flip") && !flipping) {
            Flip();
        }
        //else if (Input.GetButtonDown("Flip") && flipping) {
        //    StopFlip();
        //}
    }

    // FixedUpdate is called once per physics step
    void FixedUpdate () {
        if (flipping) {
            // transform.RotateAround(rodTransform.position, Vector3.right, rotateSpeed * Time.fixedDeltaTime);
            // transform.Rotate(Vector3.right * rotateSpeed * Time.fixedDeltaTime, Space.World);
            rodTransform.Rotate(Vector3.right * rotateSpeed * Time.fixedDeltaTime, Space.World);
            /*if (Mathf.Abs(rodTransform.rotation.eulerAngles.x) - 180 < float.Epsilon)
           { // upside down
                flipping = false;
                rb.gravityScale = -1;
                transform.SetParent(null);
            }
            else if (Mathf.Abs(rodTransform.rotation.eulerAngles.x) < float.Epsilon)
            { // rightside up
                flipping = false;
                rb.gravityScale = 1;
                transform.SetParent(null);
            }*/
            Debug.Log(rodTransform.rotation.eulerAngles.ToString());
            if ( (new Vector3(0, 0, 0) - rodTransform.rotation.eulerAngles).sqrMagnitude < closeDistance) {
                StopFlip();
            }
        }
	}

    public void Flip () {
        // flip the player from the top to the bottom
        flipping = true;
        rb.gravityScale = 0;
        transform.SetParent(rodTransform);
    }

    public void StopFlip() {
        // just stop flipping altogether
        flipping = false;
    }
}
