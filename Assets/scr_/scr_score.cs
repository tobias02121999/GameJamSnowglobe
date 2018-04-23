using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_score : MonoBehaviour {

    public int score;
    public int alarmDuration;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        alarmDuration--;

        if (alarmDuration <= 0)
        {
            SceneManager.LoadScene("sce_menu");
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), score.ToString());
    }
}
