using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_mapMovement : MonoBehaviour {

    private float rotationX;
    private float rotationZ;

    public float sensitivity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotationX += Input.GetAxis("Vertical") * sensitivity;
        rotationZ -= Input.GetAxis("Horizontal") * sensitivity;

        transform.rotation = Quaternion.Euler(rotationX, 0f, rotationZ);

        Debug.Log(Input.GetButton("AButton"));
	}
}
