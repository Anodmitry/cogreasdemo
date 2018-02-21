using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringMahLazor : MonoBehaviour {
    public GameObject Blaster;
    public GameObject player;
    public GameObject laser;
    public float delay;
    public float FadeTime;
    public float damage;
    void Start () {
        if (gameObject.name != "Blaster")
            StartCoroutine(ShoopDaWhoop());
    }
    IEnumerator ShoopDaWhoop()
    {
        float y = Blaster.transform.position.y;
        float x = Blaster.transform.position.x;
        float z = Blaster.transform.position.z;
        yield return new WaitForSeconds(delay/2);
        if (x % 5 != 0)
        {
            transform.position = new Vector3(x*18/17,y,z);
            yield return new WaitForSeconds(delay / 2);
            for (int i = -10; i <= 10; i = i + 5)
                Instantiate(laser, new Vector3(i, y, z), Quaternion.identity);
            float py = player.transform.position.y;
            if ((py <= y + 2.5) && (py >= y -2.5))
                player.SendMessage("damage", gameObject.name + ";" + damage);
        }
        else
        {
            transform.position = new Vector3(x, y * 18 / 17, z);
            yield return new WaitForSeconds(delay / 2);
            for (int j = -10; j <= 10; j = j + 5)
            {
                GameObject LaserTurn = Instantiate(laser, new Vector3(x, j, z), Quaternion.identity);
                LaserTurn.transform.Rotate(new Vector3(0, 0, 90));
            }
            float px = player.transform.position.x;
            if ((px <= x + 2.5) && (px >= x - 2.5))
                player.SendMessage("damage", gameObject.name + ";" + damage);
        }

        yield return new WaitForSeconds(FadeTime);
        Destroy(gameObject);
    }

}
