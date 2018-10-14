using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectController : MonoBehaviour {

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    private AudioSource audioSrc;

    private AudioClip[] clips;
    private System.Random randInt;

	// Use this for initialization
	void Start () 
    {
        audioSrc = GetComponent<AudioSource>();
        randInt = new System.Random();
        clips = new AudioClip[4];
        clips[0] = clip1;
        clips[1] = clip2;
        clips[2] = clip3;
        clips[3] = clip4;

        int nextClipIndex = randInt.Next(0, clips.Length);
        audioSrc.clip = clips[nextClipIndex];
	}
	
	// Update is called once per frame
	//void Update () 
 //   {
		
	//}

    public void PlayEffect()
    {
        int nextClipIndex = randInt.Next(0, clips.Length);
        audioSrc.clip = clips[nextClipIndex];
        audioSrc.Play();
    }
}
