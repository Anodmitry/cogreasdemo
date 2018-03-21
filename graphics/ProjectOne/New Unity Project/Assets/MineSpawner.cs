using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    public GameObject Mine;
    private int iterator = 0;
    private Vector3[] spawnedMinesCoords = new Vector3[10];
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
        Debug.Log(Time.time + ": Spawned " + MineSpawned.name + "; Coords " + MineSpawned.transform.position);
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
        Debug.Log(Time.time + ": Spawned " + MineSpawned.name + "; Coords " + MineSpawned.transform.position);
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
            Debug.Log(Time.time + ": Spawned " + MineSpawned.name + "; Coords " + MineSpawned.transform.position);
        }
    }
    void LimitedSpawnUpdate(string mineName)
    {
        spawnedMinesCoords[int.Parse(mineName.Substring(5)) % 10] = new Vector3(-1, -1, -1);
    }
}
