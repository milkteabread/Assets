using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryTxt : MonoBehaviour {
    
    public Vector3 angle;
    
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(angle * Time.deltaTime * 10f);
    }
}
