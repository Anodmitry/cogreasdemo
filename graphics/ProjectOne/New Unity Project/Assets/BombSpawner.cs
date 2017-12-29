using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour {

    public GameObject BombLitSprite;
    private int iterator = 0;
    public Vector3 randomPosition()
    {
        int i = (Random.Range(0, 4) - 2);
        int j = (Random.Range(0, 4) - 2);
        return new Vector3(i * 5, j * 5, 0);
    }
    void Spawnthis()
    {
        GameObject BombSpawned = Instantiate(BombLitSprite,
                    randomPosition(),
                    Quaternion.identity);
        BombSpawned.name = "Bomb " + iterator;
        iterator++;
        Debug.Log(Time.time + ": Spawned " + BombSpawned.name + "; Coords " + BombSpawned.transform.position);
    }
    void SpawnthisCoords(int[] coords)
    {
        int i = coords[0];
        int j = coords[1];
        GameObject BombSpawned = Instantiate(BombLitSprite,
                    new Vector3(i * 5, j * 5, 0),
                    Quaternion.identity);
        BombSpawned.name = "Bomb " + iterator;
        iterator++;
        Debug.Log(Time.time + ": Spawned " + BombSpawned.name + "; Coords " + BombSpawned.transform.position);
    }
}
