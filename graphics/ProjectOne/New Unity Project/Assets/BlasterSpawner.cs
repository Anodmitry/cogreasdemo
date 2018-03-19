using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterSpawner : MonoBehaviour {

    public GameObject Blaster;
    private int iterator = 0;
    private Vector3[] spawnedBlastersCoords = new Vector3[10];

    void Spawnthis()
    {
        int i = Random.Range(1, 4);
        int j = (Random.Range(0, 4) - 2);
        Vector3 coords = new Vector3(0, 0, 0);
        switch (i)
        {
            case 0:
                coords = new Vector3(j * 5, 17, 0);
                break;
            case 1:
                coords = new Vector3(-17, j * 5, 0);
                break;
            case 2:
                coords = new Vector3(j * 5, -17, 0);
                break;
            case 3:
                coords = new Vector3(17, j * 5, 0);
                break;
        }
        GameObject blasterSpawned = Instantiate(Blaster, coords, Quaternion.identity);
        blasterSpawned.transform.Rotate(new Vector3(0, 0, 90 * i));
        blasterSpawned.name = "Blaster " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + blasterSpawned.name + "; Coords " + blasterSpawned.transform.position);
    }

    void SpawnthisCoords(int[]coords)
    {
        int i = coords[0];
        int j = coords[1];
        Vector3 coordsVector = new Vector3(0, 0, 0);
        switch (i)
        {
            case 0:
                coordsVector = new Vector3(j * 5, 17, 0);
                break;
            case 1:
                coordsVector = new Vector3(-17, j * 5, 0);
                break;
            case 2:
                coordsVector = new Vector3(j * 5, -17, 0);
                break;
            case 3:
                coordsVector = new Vector3(17, j * 5, 0);
                break;
        }
        GameObject blasterSpawned = Instantiate(Blaster, coordsVector, Quaternion.identity);
        blasterSpawned.transform.Rotate(new Vector3(0, 0, 90 * i));
        blasterSpawned.name = "Blaster " + iterator;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + blasterSpawned.name + "; Coords " + blasterSpawned.transform.position);
    }
    void SpawnthisLimited()
    {
        int i = Random.Range(0, 3);
        int j = (Random.Range(0, 4) - 2);
        Vector3 coords = new Vector3 (0,0,0);
        int k = 0;
        switch (i)
        {
            case 0:
                for (k = 0; k < 5 && spawnedBlastersCoords[k].x != j * 5 && Mathf.Abs(spawnedBlastersCoords[k].x)<16 ; k++) ;
                if (k < 5) return;
                coords = new Vector3(j * 5, 17, 0);
                break;
            case 1:
                for (k = 0; k < 5 && spawnedBlastersCoords[k].y != j * 5 && Mathf.Abs(spawnedBlastersCoords[k].y) < 16; k++) ;
                if (k < 5) return;
                coords = new Vector3(-17, j * 5, 0);
                break;
            case 2:
                for (k = 0; k < 5 && spawnedBlastersCoords[k].x != j * 5 && Mathf.Abs(spawnedBlastersCoords[k].x) < 16; k++) ;
                if (k < 5) return;
                coords = new Vector3(j * 5, -17, 0);
                break;
            case 3:
                for (k = 0; k < 5 && spawnedBlastersCoords[k].y != j * 5 && Mathf.Abs(spawnedBlastersCoords[k].y) < 16; k++) ;
                if (k < 5) return;
                coords = new Vector3(17, j * 5, 0);
                break;
        }
        GameObject blasterSpawned = Instantiate(Blaster, coords, Quaternion.identity);
        blasterSpawned.transform.Rotate(new Vector3(0, 0, 90 * i));
        blasterSpawned.name = "Blaster " + iterator;
        spawnedBlastersCoords[iterator % 5] = blasterSpawned.transform.position;
        iterator++;
        Debug.Log(Time.timeSinceLevelLoad + ": Spawned " + blasterSpawned.name + "; Coords " + blasterSpawned.transform.position);
    }
    void LimitedSpawnUpdate(string blasterName)
    {
        spawnedBlastersCoords[int.Parse(blasterName.Substring(8)) % 5] = new Vector3(-1, -1, -1);
    }
}
