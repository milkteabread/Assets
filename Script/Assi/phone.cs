using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class phone : MonoBehaviour {
    public GameObject assi;
    string objectName;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        /*
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    //objectName = Hit.transform.name;
                    switch (assi.CompareTag("phoneAssi"))
                    {
                        case "smartphoneAssi":
                            SceneManager.LoadScene("CellPhoneAssiMain");
                            break;
                        default:
                            break;
                    }
                    if(assi.CompareTag("phoneAssi"))
                        SceneManager.LoadScene("CellPhoneAssiMain");
                }
            }

        }
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    if (assi.CompareTag("phoneAssi"))
                        SceneManager.LoadScene("CellPhoneAssiMain");
                }

            }

        }*/
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
                        case "smartphoneAssi":
                            SceneManager.LoadScene("CellPhoneAssiMain");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
