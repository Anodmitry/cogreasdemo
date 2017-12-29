using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRefresher : MonoBehaviour {
    private int secondsAlive = 0;
    public Text timeAlive;
	// Use this for initialization
	void Start () {
        StartCoroutine(refresher());
	}

    IEnumerator refresher()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            secondsAlive++;
            timeAlive.text = "Time alive: " + secondsAlive + "s";
        }
    }
}
