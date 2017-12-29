using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public int health = 100;
    public Text HealthText;
    public GameObject killcam;
    void damage(string info)
    {
        string[] infoSplit = info.Split(";"[0]);
        int Dmg = int.Parse(infoSplit[1]);
        health = health - Dmg;
        if (health <= 0)
        {
            killcam.name = infoSplit[0];
            killcam.tag = infoSplit[1];
            DontDestroyOnLoad(killcam);
            Application.LoadLevel("GameOver");
        }
        HealthText.text = "Health: " + health.ToString();
        Debug.Log(Time.time + ": " + name + " caused Damage: " + Dmg + "; HP: " + health);
    }

}
