using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    public GameObject Mine;
    private int iterator = 0;
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
}
