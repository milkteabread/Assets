using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forCabinet : MonoBehaviour {
    public GameObject cabinetDoorOpen1;
    public GameObject cabinetDoorOpen2;
    public GameObject cabinetDoorClose1;
    public GameObject cabinetDoorClose2;
    public GameObject cabinetDoor;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touchCount; ++i)
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
                }

            }

        }
    }
}
