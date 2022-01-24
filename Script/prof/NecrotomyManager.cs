using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecrotomyManager : MonoBehaviour {

    public enum GameState
    {
        TIMEUP,
    }
    private GameState state;
    private Timer timer;
    // Use this for initialization

    void Start () {
        PlayerPrefs.SetInt("Necro", 0);
        state = GameState.TIMEUP;
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }
    
    public void Necrotomy()
    {
        PlayerPrefs.SetInt("Necro", 1);
    }

    
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("Necro") == 1)
        {

        }
	}
}
