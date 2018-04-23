using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_animalSpawner : MonoBehaviour {

    private int alarm;

    public int alarmDuration;
    public GameObject chicken;
    public GameObject sheep;
    public bool spawnChicken;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (alarm <= 0)
        {
            if (spawnChicken) {
                Instantiate(chicken, transform.position, transform.rotation);
            } else
            {
                Instantiate(sheep, transform.position, transform.rotation);
            }
            alarm = alarmDuration;
        }

        alarm--;
	}
}
