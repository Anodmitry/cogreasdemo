using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class MedkitSpawner : MonoBehaviour
{
    public GameObject Medkit;
    private Vector3[] spawnedMedkitsCoords = new Vector3[10];
    private int iterator = 0;

    void Ins(string actobj_name, string actobj_type, string x, string y, string timefromstart, string isactive)
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

            string sqlExpression = "INSERT INTO History (actobj_name, actobj_type, x, y, timefromstart, isactive) VALUES ('" + actobj_name + "','" + actobj_type + "','" + x + "','" + y + "','" + timefromstart + "','" + isactive + "')";
            SqlCommand thisCommand = new SqlCommand(sqlExpression, dbconn);
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dbconn.Close();
            // Debug.Log("Success");
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    public Vector3 randomPosition()
    {
        int i = (Random.Range(0, 4) - 2);
        int j = (Random.Range(0, 4) - 2);
        return new Vector3(i * 5, j * 5, 0);
    }
    void Spawnthis()
    {
        GameObject MedkitSpawned = Instantiate(Medkit,
                    randomPosition(),
                    Quaternion.identity);
        MedkitSpawned.name = "Medkit " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + MedkitSpawned.name + "; Coords " + MedkitSpawned.transform.position);
        Ins(MedkitSpawned.name, "Medkit", MedkitSpawned.transform.position.x.ToString(), MedkitSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
    }
    void SpawnthisCoords(int[] coords)
    {
        int i = coords[0];
        int j = coords[1];
        GameObject MedkitSpawned = Instantiate(Medkit,
                    new Vector3(i * 5, j * 5, 0),
                    Quaternion.identity);
        MedkitSpawned.name = "Medkit " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + MedkitSpawned.name + "; Coords " + MedkitSpawned.transform.position);
        Ins(MedkitSpawned.name, "Medkit", MedkitSpawned.transform.position.x.ToString(), MedkitSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
    }
    void SpawnthisLimited()
    {
        Vector3 randpos = randomPosition();
        int i;
        for (i = 0; i < 10 && randpos != spawnedMedkitsCoords[i]; i++) ;
        if (i == 10)
        {
            GameObject MedkitSpawned = Instantiate(Medkit,
                    randomPosition(),
                    Quaternion.identity);
            MedkitSpawned.name = "Medkit " + iterator;
            spawnedMedkitsCoords[iterator % 10] = MedkitSpawned.transform.position;
            iterator++;
            Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + MedkitSpawned.name + "; Coords " + MedkitSpawned.transform.position);
            Ins(MedkitSpawned.name, "Medkit", MedkitSpawned.transform.position.x.ToString(), MedkitSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
        }
    }
    void LimitedSpawnUpdate(string medkitName)
    {
        spawnedMedkitsCoords[int.Parse(medkitName.Substring(7)) % 10] = new Vector3(-1, -1, -1);
    }
}
