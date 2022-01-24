using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComputerCode : MonoBehaviour {
   
    private TouchScreenKeyboard keyboard;
    public string stringToEdit = "a";
    int num = 0;
    public GameObject text;
    public GameObject plane;

   /* public void code()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        num = 1;
    }*/

    void OnMouseDown()
    {
        if (plane.CompareTag("CoWCom"))
        {
            keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        }
    }

        private void Update()
    {
        if(keyboard!=null)
        {
            stringToEdit = keyboard.text;
        }

        if (stringToEdit == "criminal")
        {
            SceneManager.LoadScene("CoWComputerMain");
            num = 0;
        }

        if(stringToEdit == " " || stringToEdit == "" || stringToEdit == "a" || stringToEdit == "c" || stringToEdit == "cr" || stringToEdit == "cri" || stringToEdit == "crim" || stringToEdit == "crimi" || stringToEdit == "crimin"
             || stringToEdit == "crimina")
        {
            num = 0;
        }
        else { num = 1; }
        if(num ==1 )
        {
            text.SetActive(true);
        }
            
    }
   

  

   

}
