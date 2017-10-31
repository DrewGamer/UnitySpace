using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer_activate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        Debug.Log("Enter");
    }

    private void OnMouseExit()
    {
        Debug.Log("Exit");
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse Click");

    }
}
