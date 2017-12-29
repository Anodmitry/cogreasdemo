using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringMahLazor : MonoBehaviour {
    public GameObject Blaster;
    public GameObject player;
    public GameObject laser;
    public float PrepareTimeFrom = 1;
    public float PrepareTimeTo = 3;
    public float delay = 2;
    public float FadeTime = 1;
    public float damage = 50;
    void Start () {
        if (gameObject.name != "Blaster")
            StartCoroutine(ShoopDaWhoop(Random.Range(PrepareTimeFrom,PrepareTimeTo)));
    }
    IEnumerator ShoopDaWhoop(float PrepareTime)
    {
        //yield return new WaitForSeconds(PrepareTime);
        //Debug.Log(Time.time + ": red eye " + gameObject.name.ToString());
        yield return new WaitForSeconds(delay);
        float y = Blaster.transform.position.y;
        float x = Blaster.transform.position.x;
        float z = Blaster.transform.position.z;
        float py = player.transform.position.y;
        float px = player.transform.position.x;
        if (x % 5 != 0)
        {
            for (int i = -10; i <= 10; i = i + 5)
                Instantiate(laser, new Vector3(i, y, z), Quaternion.identity);
            if (py == y)
                player.SendMessage("damage", gameObject.name + ";" + damage);
        }
        else
        {
            for (int j = -10; j <= 10; j = j + 5)
            {
                GameObject LaserTurn = Instantiate(laser, new Vector3(x, j, z), Quaternion.identity);
                LaserTurn.transform.Rotate(new Vector3(0, 0, 90));
            }
            if (px == x)
                player.SendMessage("damage", gameObject.name + ";" + damage);
        }

        yield return new WaitForSeconds(FadeTime);
        Destroy(gameObject);
    }

}
