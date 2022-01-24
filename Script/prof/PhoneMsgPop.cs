using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneMsgPop : MonoBehaviour {

 
    public GameObject msg;
    string objectName;
    bool is_mouse_down;

    void OnMouseDown()
    {
        is_mouse_down = true;

    }

     void OnMouseUp()
     {
         is_mouse_down = false;
     }

    void Start()
    {
        msg.SetActive(false);
    }

    void Update()
    {
       /*( for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    objectName = Hit.transform.name;
                    switch (objectName)
                    {
                        case "msg1":
                            msg.SetActive(true);
                            break;
                        default:
                            break;
                    }
                }
                else
                msg.SetActive(false);
            }
        }*/

        if (is_mouse_down == true)
            msg.SetActive(true);
        else
            msg.SetActive(false);
    }
}
