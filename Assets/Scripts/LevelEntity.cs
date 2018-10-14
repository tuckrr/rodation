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
    public float endTimer = 5;
    

    private bool win = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (active) {
            transform.position += Vector3.right * levelSpeed * -1 * Time.deltaTime;
        } else {
            endTimer -= Time.deltaTime;
            if (endTimer <= 0) {
                if (win) {
                    // next level
                } else {
                    // level select
                }
            }
        }
	}

    public void EndLevel(int score) {
        if (score < 0)
        {
            // display a 'you lost' message

        } else {
            win = true;
            TextMesh t = gameObject.AddComponent<TextMesh>();
            t.anchor = TextAnchor.MiddleCenter;
            t.transform.position = Camera.main.transform.position + new Vector3(0, 0, 3);
            t.color = Color.black;
            t.fontSize = 64;
            t.characterSize = 0.12f;
            if (score <= gold)
            {
                t.text = "You got a gold medal! Next level starting...";

            } else if (score <= silver) {
                t.text = "You got a silver medal! Next level starting...";

            }
            else if (score <= bronze) {
                t.text = "You got a bronze medal! Next level starting...";
            }
            else {
                t.text = "Next level starting...";
            }
        }
    }
}
