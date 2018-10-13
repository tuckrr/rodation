﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // keep track of where gravity should point
    public bool isUp = true;
    public bool isDown = false;

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.gravityScale = 0;
        if (isUp) { rb.gravityScale++; }
        if (isDown) { rb.gravityScale--; }
	}

    void Flip () {
        // flip the player from the top to the bottom
    }
}
