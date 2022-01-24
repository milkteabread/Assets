using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPanel : MonoBehaviour {

    public GameObject instructPanel;
	// Use this for initialization
	void Awake() {
		if(PlayerPrefs.GetInt("Instruct") == 0)
        {
            instructPanel.SetActive(true);
            PlayerPrefs.SetInt("Instruct", 1);
        }
        else
            instructPanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
