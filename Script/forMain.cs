using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Vuforia;

public class forMain : MonoBehaviour
{
    
    public GameObject Cup;
    public GameObject msgtxt;
    public GameObject btn;
    string objectName;

    public bool a;
    void Start()
    {
        Cup.SetActive(false);
        msgtxt.SetActive(false);
    }

    public void Idle()
    {
        transform.position = transform.position;
    }

    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
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
                        case "smartphone":
                            Idle();
                            SceneManager.LoadScene("CellPhoneProfMain");
                            break;
                        case "cup":
                            Idle();
                            btn.SetActive(true);
                            Cup.SetActive(true);
                            break;
                        case "Radio":
                            Idle();
                            Cup.SetActive(true);
                            break;
                        case "message":
                            Idle();
                            msgtxt.SetActive(true);
                            break;
                        case "PC (1)":
                            Idle();
                            SceneManager.LoadScene("CoWCompuerLock");
                            break;
                        case "Monitor005":
                            Idle();
                            SceneManager.LoadScene("CoWCompuerLock");
                            break;
                        case "pc_main":
                            Idle();
                            SceneManager.LoadScene("CoWCompuerLock");
                            break;
                        case "door":
                            Idle();
                            SceneManager.LoadScene("RoomCCTV");
                            break;
                        case "Window":
                            Idle();
                            SceneManager.LoadScene("OutOfWindow");
                            break;
                        case "fellow_professor":
                            Idle();
                            SceneManager.LoadScene("Fail");
                            break;
                        case "guard":
                            Idle();
                            SceneManager.LoadScene("Fail");
                            break;
                        case "assistant":
                            Idle();
                            SceneManager.LoadScene("Fail");
                            break;
                        case "back_people":
                            Idle();
                            SceneManager.LoadScene("Success");
                            break;
                        case "smartphoneAssi":
                            Idle();
                            SceneManager.LoadScene("CellPhoneAssiMain");
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Ended)
            {
                Cup.SetActive(false);
                msgtxt.SetActive(false);
            }
        }
    }
}


