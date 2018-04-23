using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cameraMovement : MonoBehaviour {

    public float xOffset;
    public float yOffset;
    public float zOffset;
    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x + xOffset, player.position.y + yOffset, player.position.z + zOffset);
	}
}
