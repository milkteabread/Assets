using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {

        PlayerPrefs.SetInt("Assi", 0);
        PlayerPrefs.SetInt("Guard", 0);
        PlayerPrefs.SetInt("CoW", 0);
        PlayerPrefs.SetInt("Instruct", 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
