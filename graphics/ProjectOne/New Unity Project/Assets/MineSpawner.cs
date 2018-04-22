using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class MineSpawner : MonoBehaviour
{
    public GameObject Mine;
    private int iterator = 0;
    private Vector3[] spawnedMinesCoords = new Vector3[10];

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
        GameObject MineSpawned = Instantiate(Mine,
                    randomPosition(),
                    Quaternion.identity);
        MineSpawned.name = "Mine " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + MineSpawned.name + "; Coords " + MineSpawned.transform.position);
        Ins(MineSpawned.name, "Medkit", MineSpawned.transform.position.x.ToString(), MineSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
    }
    void SpawnthisCoords(int[] coords)
    {
        int i = coords[0];
        int j = coords[1];
        GameObject MineSpawned = Instantiate(Mine,
                    new Vector3(i * 5, j * 5, 0),
                    Quaternion.identity);
        MineSpawned.name = "Mine " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + MineSpawned.name + "; Coords " + MineSpawned.transform.position);
        Ins(MineSpawned.name, "Medkit", MineSpawned.transform.position.x.ToString(), MineSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
    }
    void SpawnthisLimited()
    {
        Vector3 randpos = randomPosition();
        int i;
        for (i = 0; i < 10 && randpos != spawnedMinesCoords[i]; i++) ;
        if (i == 10)
        {
            GameObject MineSpawned = Instantiate(Mine,
                    randomPosition(),
                    Quaternion.identity);
            MineSpawned.name = "Mine " + iterator;
            spawnedMinesCoords[iterator % 10] = MineSpawned.transform.position;
            iterator++;
            Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + MineSpawned.name + "; Coords " + MineSpawned.transform.position);
            Ins(MineSpawned.name, "Medkit", MineSpawned.transform.position.x.ToString(), MineSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
        }
    }
    void LimitedSpawnUpdate(string mineName)
    {
        spawnedMinesCoords[int.Parse(mineName.Substring(5)) % 10] = new Vector3(-1, -1, -1);
    }
}
