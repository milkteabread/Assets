using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour {
    public GameObject txt1, txt2, txt3;
    string objectName;
    private bool ifHit;
    private bool onetime = true;

    // Use this for initialization
    void Start()
    {
        ifHit = false;
        onetime = true;
    }

	
	// Update is called once per frame
	void Update () {
        
        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;

        Debug.DrawRay(transform.position, forward, Color.green);

        if (onetime)
        {
            if (Physics.Raycast(transform.position, forward, out hit))
            {
                objectName = hit.transform.name;
                if (objectName == "note")
                {
                    Debug.Log("hit");

                    //ifHit = true;
                    //  activeTxt();
                    txt1.SetActive(true);
                    txt2.SetActive(true);
                    txt3.SetActive(true);
                    onetime = false;
                }
                else
                    onetime = true;

            }
            else
            {
                txt1.SetActive(false);
                txt2.SetActive(false);
                txt3.SetActive(false);
                onetime = true;
            }
        }
       /* else if(!onetime)
        {
            onetime = true;
        }
        
        

        if(ifHit)
        {
            txt1.SetActive(true);
            txt2.SetActive(true);
            txt3.SetActive(true);
            onetime = true;
        }
        else if (!ifHit)
        {
            txt1.SetActive(false);
            txt2.SetActive(false);
            txt3.SetActive(false);
            onetime = false;
        }*/
    } 
    
    void activeTxt()
    {
        txt1.SetActive(true);
        txt2.SetActive(true);
        txt3.SetActive(true);
    }

}
