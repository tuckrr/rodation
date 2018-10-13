using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEntity : MonoBehaviour {

    public float levelSpeed = 1;
    public int gold = 3;
    public int silver = 5;
    public int bronze = 7;

    public int levelNumber;

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

    public void EndLevel(int score) {
        if (score < 0)
        {
            // fail, should restart the level

        } else if (score <= gold)
        {
            // gold medal

        } else if (score <= silver) {
            // silver medal

        } else if (score <= bronze) {
            // bronze

        } else {
            // no medal
        }
        // go to level select
        return;
    }
}
