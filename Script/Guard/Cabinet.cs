using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Cabinet : MonoBehaviour
{

    public GameObject cabinetDoorOpen1;
    public GameObject cabinetDoorOpen2;
    public GameObject cabinetDoorClose1;
    public GameObject cabinetDoorClose2;
    public GameObject cabinetDoor;
    

    void Update()
    {
        /*for (int i = 0; i < Input.touchCount; ++i)
        {

            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    if (cabinetDoor.CompareTag("cabinetGuard"))
                    {
                        cabinetDoorOpen1.SetActive(true);
                        cabinetDoorOpen2.SetActive(true);
                        cabinetDoorClose1.SetActive(false);
                        cabinetDoorClose2.SetActive(false);
                    }
                    /*else
                    {
                        cabinetDoorOpen1.SetActive(false);
                        cabinetDoorOpen2.SetActive(false);
                        cabinetDoorClose1.SetActive(true);
                        cabinetDoorClose2.SetActive(true);
                    }
                }

            }
            
        }*/


    }
}
