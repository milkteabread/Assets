using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour {

    public AudioClip[] aClips;
    public AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
        myAudioSource = GetComponent<AudioSource>();
	}

    public GameObject plane;

    void OnMouseDown()
    {
        if (plane.CompareTag("voiceAssi"))
        {
            myAudioSource.clip = aClips[0];
            myAudioSource.Play();
        }
    }

}
