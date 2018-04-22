using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;


public class BombSpawner : MonoBehaviour {

    public GameObject Bomb;
    private int iterator = 0;
    private Vector3[] spawnedBombsCoords = new Vector3[10];
    public Vector3 randomPosition()
    {
        int i = (Random.Range(0, 4) - 2);
        int j = (Random.Range(0, 4) - 2);
        return new Vector3(i * 5, j * 5, 0);
    }
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


    void Spawnthis()
    {
        GameObject BombSpawned = Instantiate(Bomb,
                    randomPosition(),
                    Quaternion.identity);
        BombSpawned.name = "Bomb " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + BombSpawned.name + "; Coords " + BombSpawned.transform.position);
        Ins(BombSpawned.name, "bomb", BombSpawned.transform.position.x.ToString(), BombSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");

    }
    void SpawnthisCoords(int[] coords)
    {
        int i = coords[0];
        int j = coords[1];
        GameObject BombSpawned = Instantiate(Bomb,
                    new Vector3(i * 5, j * 5, 0),
                    Quaternion.identity);
        BombSpawned.name = "Bomb " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + BombSpawned.name + "; Coords " + BombSpawned.transform.position);
        Ins(BombSpawned.name, "bomb", BombSpawned.transform.position.x.ToString(), BombSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
    }
    void SpawnthisLimited()
    {
        Vector3 randpos = randomPosition();
        int i;
        for (i = 0; i < 10 && randpos != spawnedBombsCoords[i]; i++) ;
        if (i == 10)
        {
            GameObject BombSpawned = Instantiate(Bomb,
                        randpos,
                        Quaternion.identity);
            BombSpawned.name = "Bomb " + iterator;
            spawnedBombsCoords[iterator % 10] = BombSpawned.transform.position;
            iterator++;
            Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + BombSpawned.name + "; Coords " + BombSpawned.transform.position);
            Ins(BombSpawned.name, "bomb", BombSpawned.transform.position.x.ToString(), BombSpawned.transform.position.y.ToString(), Time.timeSinceLevelLoad.ToString(), "1");
        }
    }
    void LimitedSpawnUpdate(string bombName)
    {
        spawnedBombsCoords[int.Parse(bombName.Substring(5)) % 10] = new Vector3(-1,-1,-1);
    }
}
