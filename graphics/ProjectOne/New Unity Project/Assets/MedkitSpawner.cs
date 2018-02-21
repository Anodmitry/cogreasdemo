using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitSpawner : MonoBehaviour
{
    public GameObject Medkit;
    private int iterator = 0;
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
        Debug.Log(Time.time + ": Spawned " + MedkitSpawned.name + "; Coords " + MedkitSpawned.transform.position);
    }
    void SpawnthisCoords(int[] coords)
    {
        int i = coords[0];
        int j = coords[1];
        GameObject MedkitSpawned = Instantiate(Medkit,
                    new Vector3(i * 5, j * 5, 0),
                    Quaternion.identity);
        MedkitSpawned.name = "Mine " + iterator;
        iterator++;
        Debug.Log(Time.time + ": Spawned " + MedkitSpawned.name + "; Coords " + MedkitSpawned.transform.position);
    }
}
