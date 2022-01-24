using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public GameObject secretDoor;
    public GameObject doorOpen;
    public GameObject cube;
  //  bool is_door_active;
    string objectName;
    // Use this for initialization
    void Start () {
        //is_door_active = false;
    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;

        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            objectName = hit.transform.name;
            if (objectName == "door_cube")
            {
                Debug.Log("hit");

                secretDoor.SetActive(true);
                cube.SetActive(false);
               // is_door_active = true;
            }
        }


       /* for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    if (doorOpen.CompareTag("doorGuard"))
                        SceneManager.LoadScene("RoomCCTV");
                }

            }

        }*/
    }
}
