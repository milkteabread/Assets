using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour {
    public static AudioSource myAudioSource;
    
    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(transform.gameObject);
       
    }
}
