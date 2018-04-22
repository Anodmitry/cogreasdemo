using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {
    private GameObject killcam;
    public Text timeText;

    // Use this for initialization
    void Awake () {
        killcam = GameObject.FindGameObjectWithTag("Finish");
        timeText.text = timeText.text + killcam.name;
        DestroyObject(killcam);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
