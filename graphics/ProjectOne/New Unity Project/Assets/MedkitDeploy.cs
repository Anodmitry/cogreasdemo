using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitDeploy : MonoBehaviour
{
    public float ExpTime = 5;
    public GameObject player;
    public int damage = -10;

    void Start()
    {
        if (gameObject.name != "Medkit")
            StartCoroutine(Fade());
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(ExpTime);
        Destroy(gameObject);
    }


    void Update()
    {
        Vector3 playerCoords = player.transform.position;
        if (((gameObject.transform.position.x - 2.5 <= playerCoords.x) && (gameObject.transform.position.x + 2.5 >= playerCoords.x)) && ((gameObject.transform.position.y - 2.5 <= playerCoords.y) && (gameObject.transform.position.y + 2.5 >= playerCoords.y)))
        {
            player.SendMessage("damage", gameObject.name + ";" + damage);
            Destroy(gameObject);
        }
    }
}
