using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // keep track of where gravity should point - for in editor shenanigans
    public bool isUp = true;
    public bool isDown = false;

    private bool flipping = false;

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void Update ()
    {
        if (Input.GetKeyDown("Flip") && !flipping) {
            Flip();
        }
    }

    // FixedUpdate is called once per physics step
    void FixedUpdate () {
        rb.gravityScale = 0;
        if (isUp) { rb.gravityScale++; }
        if (isDown) { rb.gravityScale--; }

        if (flipping) {

        }
	}

    public void Flip () {
        // flip the player from the top to the bottom
        flipping = true;
        rb.gravityScale = 0;

    }
}
