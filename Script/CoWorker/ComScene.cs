using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ComScene : MonoBehaviour
{

    public GameObject icon;

    void OnMouseDown()
    {
        if (icon.CompareTag("CoWComFile"))
        {
            SceneManager.LoadScene("CoWComputerFile");
        }
        else if (icon.CompareTag("CoWComInternet"))
        {
            SceneManager.LoadScene("CoWComputerMail");
        }
        else if (icon.CompareTag("CoWComBack"))
        {
            SceneManager.LoadScene("CoWComputerMain");
        }
            
    }

}
