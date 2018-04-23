using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalPickup : MonoBehaviour {
	
	public GameObject car;
	public GameObject varken;
	public GameObject kip;
	public GameObject schaap;

	void onTriggerEnter(Collision collision){
		if (collision.gameObject.tag == "Varken"){
			varken.SetActive(true);
			Destroy(collision.gameObject);
		} else if (collision.gameObject.tag == "Kip"){
			kip.SetActive(true);
			Destroy(collision.gameObject);
		} else if (collision.gameObject.tag == "Schaap"){
			schaap.SetActive(true);
			Destroy(collision.gameObject);
		}
	}
}


