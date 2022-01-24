using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CupTextPopUp : MonoBehaviour {
    public GameObject Cup;

    bool is_mouse_drag;

    RaycastHit hit;
    Ray ray;

    private void Start()
    {
        Cup.SetActive(false);
        is_mouse_drag = false;

    }
    void OnMouseDrag()
    {
        is_mouse_drag = true;
    }
    void OnMouseUp()
    {
        is_mouse_drag = false;
    }

  
    void Update()
    {
        if (is_mouse_drag == true)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(" you clicked on " + hit.collider.gameObject.name);

                if (hit.collider.gameObject.name == "cup")
                {
                    Cup.SetActive(true);
                }
            }
        }
        else
            Cup.SetActive(false);
    }
}

