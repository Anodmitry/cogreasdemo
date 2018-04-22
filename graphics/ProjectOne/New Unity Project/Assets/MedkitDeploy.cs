using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class MedkitDeploy : MonoBehaviour
{
    public float ExpTime = 5;
    public GameObject player;
    public int damage = -10;
    private GameObject medkitSpawner;

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

    void Start()
    {
        if (gameObject.name != "Medkit")
            StartCoroutine(Fade());
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(ExpTime);
        medkitSpawner = GameObject.Find("Medkit");
        medkitSpawner.SendMessage("LimitedSpawnUpdate", gameObject.name);
        Upd(gameObject.name, "isactive", "0");
        Destroy(gameObject);
    }


    void Update()
    {
        Vector3 playerCoords = player.transform.position;
        if (((gameObject.transform.position.x - 2.5 <= playerCoords.x) && (gameObject.transform.position.x + 2.5 >= playerCoords.x)) && ((gameObject.transform.position.y - 2.5 <= playerCoords.y) && (gameObject.transform.position.y + 2.5 >= playerCoords.y)))
        {
            player.SendMessage("damage", gameObject.name + ";" + damage);
            medkitSpawner = GameObject.Find("Medkit");
            medkitSpawner.SendMessage("LimitedSpawnUpdate", gameObject.name);
            Upd(gameObject.name, "isactive", "0");
            Destroy(gameObject);
        }
    }
}
