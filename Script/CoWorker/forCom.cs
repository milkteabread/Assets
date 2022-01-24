using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forCom : MonoBehaviour {
    public GameObject obj;

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
                    if (obj.CompareTag("CoWCom"))
                    {
                        Idle();
                        SceneManager.LoadScene("CoWComputerLock");
                    }
                }

            }

        }
    }
}
