using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_mapMovement : MonoBehaviour {

    private float rotationX;
    private float rotationZ;

    public float sensitivity;
    public float rotationXClamp;
    public float rotationZClamp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotationX = Mathf.Clamp(rotationX + Input.GetAxis("Vertical") * sensitivity, -rotationXClamp, rotationXClamp);
        rotationZ = Mathf.Clamp(rotationZ - Input.GetAxis("Horizontal") * sensitivity, -rotationZClamp, rotationZClamp);

        transform.rotation = Quaternion.Euler(rotationX, 0f, rotationZ);
	}
}
