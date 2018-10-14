using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    AudioSource audioSrc;
    bool play;

	// Use this for initialization
	void Awake () 
    {
        DontDestroyOnLoad(this.gameObject);
        audioSrc = GetComponent<AudioSource>();

        play = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (play & !audioSrc.isPlaying)
        {
            audioSrc.Play();
            Debug.Log("PLAYING AUDIO: " + audioSrc.clip.ToString());
            play = false;
        }

        if (audioSrc.isPlaying)
        {
            Debug.Log("Already playing: " + audioSrc.clip.ToString());
        }

        //if (!play)
        //{
        //    audioSrc.Stop();
        //}
	}
}
