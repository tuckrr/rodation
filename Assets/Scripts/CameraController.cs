using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController player;
    public float cameraMovementSize;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(transform.position.x, player.transform.position.y * cameraMovementSize, transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        if (player.flipping) {
            transform.position = new Vector3(transform.position.x, player.transform.position.y * cameraMovementSize, transform.position.z);
        }
    }
}
