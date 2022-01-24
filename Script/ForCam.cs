using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ForCam : MonoBehaviour {

    RaycastHit hit;
    Ray ray;
    bool is_mouse_down;
    void OnMouseDown()
    {
        // load a new sceneif(house.CompareTag("Korean"))
        is_mouse_down = true;

    }

   /* void OnMouseExit()
    {
        is_mouse_down = false;
    }*/

    void Start()
    {
        is_mouse_down = false;
    }

    void Update()
    {
        if (is_mouse_down == true)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(" you clicked on " + hit.collider.gameObject.name);

                if (hit.collider.gameObject.name == "smartphone")
                {
                    SceneManager.LoadScene("CellPhoneProfMain");
                }
            }
        }
    }
}
