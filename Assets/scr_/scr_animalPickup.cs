﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_animalPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<scr_score>().score++;
            Destroy(this.gameObject);
        }
    }
}
