using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEntity : MonoBehaviour {

    public float levelSpeed = 1;
    public bool active = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (active) {
            transform.position += Vector3.right * levelSpeed * -1 * Time.deltaTime;
        }
	}
}
