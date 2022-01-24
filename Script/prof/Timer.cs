using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int timeLimit = 10;
    private float timeRemaining;
    private bool timerStarted;
    public GameObject panel;
    public GameObject btn;
    public GameObject btn2;

    // Use this for initialization
    void Start () {
        // txt = gameObject.GetComponent<necroText> ();
       // txt.GetComponent<necroText>().text = "부검중";
        ResetTimer();
        PlayerPrefs.SetInt("Necro", 0);
    }

    public void NecrtoBtn()
    {
        StartTimer();
       // btn.SetActive(false);
        btn2.SetActive(true);
    }
    public void ResetTimer()
    {
        timeRemaining = timeLimit;
        timerStarted = false;
    }

    public void StartTimer()
    {
        timerStarted = true;
    }

    public void StopTimer()
    {
        timerStarted = false;
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }
	// Update is called once per frame
	void Update () {
        
        if (timerStarted)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerStarted = false;
                panel.SetActive(true);
                btn.SetActive(false);
                btn2.SetActive(false);
            }
        }
	}
}
