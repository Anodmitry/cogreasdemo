using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterSpawner : MonoBehaviour {

    public GameObject Blaster;
    private GameObject BlasterControl;
    private int iterator = 0;

    void Spawnthis()
    {
        int i = Random.Range(1, 4);
        int j = (Random.Range(0, 4) - 2);
        switch (i)
        {
            case 1:
                BlasterControl = Instantiate(Blaster,
                new Vector3(-17, j * 5, 0),
                Quaternion.identity);
                BlasterControl.transform.Rotate(new Vector3(0, 0, 90));
                break;
            case 2:
                BlasterControl = Instantiate(Blaster,
                new Vector3(17, j * 5, 0),
                Quaternion.identity);
                BlasterControl.transform.Rotate(new Vector3(0, 0, 270));
                break;
            case 3:
                BlasterControl = Instantiate(Blaster,
                new Vector3(j * 5, -17, 0),
                Quaternion.identity);
                BlasterControl.transform.Rotate(new Vector3(0, 0, 180));
                break;
            case 4:
                BlasterControl = Instantiate(Blaster,
                new Vector3(j * 5, 17, 0),
                Quaternion.identity);
                break;
        }
        BlasterControl.name = "Blaster " + iterator;
        iterator++;
        Debug.Log(Time.time + ": Spawned " + BlasterControl.name + "; Coords " + BlasterControl.transform.position);
    }

    void SpawnthisCoords(int[]coords)
    {
        int i = coords[0];
        int j = coords[1];
        switch (i)
        {
            case 4:
                BlasterControl = Instantiate(Blaster,
                new Vector3(-17, j * 5, 0),
                Quaternion.identity);
                BlasterControl.transform.Rotate(new Vector3(0, 0, 90));
                break;
            case 2:
                BlasterControl = Instantiate(Blaster,
                new Vector3(17, j * 5, 0),
                Quaternion.identity);
                BlasterControl.transform.Rotate(new Vector3(0, 0, 270));
                break;
            case 3:
                BlasterControl = Instantiate(Blaster,
                new Vector3(j * 5, -17, 0),
                Quaternion.identity);
                BlasterControl.transform.Rotate(new Vector3(0, 0, 180));
                break;
            case 1:
                BlasterControl = Instantiate(Blaster,
                new Vector3(j * 5, 17, 0),
                Quaternion.identity);
                break;
        }
        BlasterControl.name = "Blaster " + iterator;
        iterator++;
        Debug.Log(Time.time + ": Spawned " + BlasterControl.name + "; Coords " + BlasterControl.transform.position);
    }
}
