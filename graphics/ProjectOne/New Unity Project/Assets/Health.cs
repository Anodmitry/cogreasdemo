using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    private int nextTime = 1;
    public int health = 100;
    public float overHealDecayModifierPerSec = 0.1f;
    public Text HealthText;
    public GameObject killcam;
    void damage(string info)
    {
        string[] infoSplit = info.Split(";"[0]);
        int Dmg = int.Parse(infoSplit[1]);
        health = health - Dmg;
        if (health <= 0)
        {
            killcam.name = Time.timeSinceLevelLoad.ToString();
            DontDestroyOnLoad(killcam);
            Application.LoadLevel("GameOver");           
        }
        HealthText.text = "Health: " + health.ToString();
        Debug.Log(Time.timeSinceLevelLoad + ": " + name + " caused Damage: " + Dmg + "; HP: " + health);
    }
    private void Update()
    {
        if (Time.time >= nextTime)
        {
            if (health > 100)
            {
                if (health > 105)
                    health = health - Mathf.CeilToInt((health-100) * overHealDecayModifierPerSec);
                else health = health - 1;
                HealthText.text = "Health: " + health.ToString();
            }
            nextTime++;
        }
    }
}
