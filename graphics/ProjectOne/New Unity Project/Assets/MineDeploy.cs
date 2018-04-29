using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class MineDeploy : MonoBehaviour {
    private GameObject mineSpawner;
    public float ExpTime = 5;
    public GameObject explosion;
    public GameObject player;
    private int damage = 10;
    private int deployTime = 2;
    private bool armed = false;

    void ChangeDamage(int dmg)
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
        if (gameObject.name != "Mine")
            StartCoroutine(Fade());
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(deployTime);
        armed = true;
        yield return new WaitForSeconds(ExpTime - deployTime);
        mineSpawner = GameObject.Find("Mine");
        mineSpawner.SendMessage("LimitedSpawnUpdate", gameObject.name);
        Upd(gameObject.name, "isactive", "0");
        Destroy(gameObject);
    }
	
	
	void Update () {
        Vector3 playerCoords = player.transform.position;
        if (armed & ((gameObject.transform.position.x - 2.5 <= playerCoords.x) && (gameObject.transform.position.x + 2.5 >= playerCoords.x)) && ((gameObject.transform.position.y - 2.5 <= playerCoords.y) && (gameObject.transform.position.y + 2.5 >= playerCoords.y)))
        {
            player.SendMessage("damage", gameObject.name + ";" + damage);
            mineSpawner = GameObject.Find("Mine");
            mineSpawner.SendMessage("LimitedSpawnUpdate", gameObject.name);
            Upd(gameObject.name, "isactive", "0");
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
