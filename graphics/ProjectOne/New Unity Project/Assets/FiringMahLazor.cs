using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class FiringMahLazor : MonoBehaviour {
    private GameObject blasterSpawner;
    public GameObject player;
    public GameObject laser;
    private float delay = 2;
    private float FadeTime = 0.3f;
    private float damage = 40;

    void ChangeDamage(float dmg)
    {
        damage = dmg;
    }

    void Upd(string actobj_name, string paramforupdate, string newvalue)
    {
        try
        {
            string connstr =
                 @"Data Source=127.0.0.1\sqlexpress01;" +
                 "user id = admin;" +
                 "password = adminadmin;" +
                 "Initial Catalog=envdb_mini;";

            SqlConnection dbconn = new SqlConnection(connstr);
            dbconn.Open();
            string sqlExpression = "UPDATE History SET " + paramforupdate + " = '" + newvalue + "' WHERE actobj_name = '" + actobj_name + "'";
            SqlCommand thisCommand = new SqlCommand(sqlExpression, dbconn);
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dbconn.Close();
            //Debug.Log("Success");
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    void Start () {
        if (gameObject.name != "Blaster")
            StartCoroutine(ShoopDaWhoop());
    }
    IEnumerator ShoopDaWhoop()
    {
        float y = transform.position.y;
        float x = transform.position.x;
        float z = transform.position.z;
        yield return new WaitForSeconds(delay / 2);
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
        blasterSpawner = GameObject.Find("Blaster");
        blasterSpawner.SendMessage("LimitedSpawnUpdate", gameObject.name);
        Upd(gameObject.name, "isactive", "0");
        Destroy(gameObject);
    }

}
