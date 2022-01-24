using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCriminalManager : MonoBehaviour
{
    public GameObject btn;
    void OnLevelWasLoaded()
    {
        if (PlayerPrefs.GetInt("Assi") == 1 && PlayerPrefs.GetInt("Guard") == 1 && PlayerPrefs.GetInt("CoW") == 1)
        {
            btn.SetActive(true);
        }
    }
}
