using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using ChangeDB_Lib;

public class Spawner : MonoBehaviour {
    public float spawnWait;
    public float startWait;
    public int[] Weights;
    public GameObject[] Hazard;
    private bool randomSpawn = true;

    //manual spawn
    public string[] readScriptedSpawn(string Adress)
    {
        string[] lines = System.IO.File.ReadAllLines(Adress);
        return lines;
    }
    public void StartSpawnScripted()
    {
        StartCoroutine(SpawnScripted(readScriptedSpawn("kek.txt")));
    }
    IEnumerator SpawnScripted(string[] Commands)
    {
        float timer = 0;
        foreach(string command in Commands)
        {
            string[] directive = command.Split(","[0]);
            float thisTime = float.Parse(directive[0]);
            int type = int.Parse(directive[1]);
            yield return new WaitForSeconds(thisTime - timer);
            timer = thisTime;
            switch(type)
            {
                case -1:// вкл/выкл рандомный спаун
                    toggleRandomSpawn(int.Parse(directive[2])==1);
                    break;
                case -2:
                    spawnWait = float.Parse(directive[2]);
                    break;
                case -3:
                    for (int i = 0; i < Weights.Length; i++)
                        Weights[i] = int.Parse(directive[i + 2]);
                    break;
                default:
                    if (directive.Length < 3)
                    {
                        Hazard[type].SendMessage("Spawnthis");
                    }
                    else
                    {
                        int[] coords = new int[] { int.Parse(directive[2]), int.Parse(directive[3]) };
                        Debug.Log(coords);
                        Hazard[type].SendMessage("SpawnthisCoords", coords);
                    }
                    break;

            }      
        }
    }


    //random spawn
    public void toggleRandomSpawn(bool s)
    {
        randomSpawn = s;
        if (randomSpawn)
            StartCoroutine(SpawnHazards());
    }
    public void spawnNext()
    {
        int i = Random.Range(0, Weights[Weights.Length-1]+1);
        int j;
        for (j = 0; i > Weights[j] && j < Weights.Length; j++);
        Hazard[j].SendMessage("Spawnthis");
    }

    void Start()
    {
        /*  Debug.Log("1");
          try
          {
              string path = @"D:\ProjectOne\New Unity Project\Assets\Plugins\End_dll\Data.accdb";
              ChangeDB_Lib.Change_DB connector = new ChangeDB_Lib.Change_DB();
              connector.ConnectToDb("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Data.accdb;Persist Security Info=False;");
              Debug.Log("Я внутри");
              connector.CloseConnection();
              Debug.Log("Я снаружи");
          }
          catch (System.Exception e) {
              Debug.Log(e.Message);
          }*/
        StartSpawnScripted();
        StartCoroutine(SpawnHazards());
    }

    IEnumerator SpawnHazards()
    {
        yield return new WaitForSeconds(startWait);
        while (randomSpawn)
        {
            yield return new WaitForSeconds(spawnWait);
            spawnNext();
        }
    }
}
