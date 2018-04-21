using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    void Spawnthis()
    {
        GameObject BombSpawned = Instantiate(Bomb,
                    randomPosition(),
                    Quaternion.identity);
        BombSpawned.name = "Bomb " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + BombSpawned.name + "; Coords " + BombSpawned.transform.position);
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
        }
    }
    void LimitedSpawnUpdate(string bombName)
    {
        spawnedBombsCoords[int.Parse(bombName.Substring(5)) % 10] = new Vector3(-1,-1,-1);
    }
}
