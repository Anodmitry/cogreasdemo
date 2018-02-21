using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDeploy : MonoBehaviour {
    public float ExpTime = 5;
    public GameObject explosion;
    public GameObject player;
    public int damage = 10;
    public int deployTime = 2;
    private bool armed = false;

    void Start () {
        if (gameObject.name != "Mine")
            StartCoroutine(Fade());
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(deployTime);
        armed = true;
        yield return new WaitForSeconds(ExpTime - deployTime);
        Destroy(gameObject);
    }
	
	
	void Update () {
        Vector3 playerCoords = player.transform.position;
        if (armed & ((gameObject.transform.position.x - 2.5 <= playerCoords.x) && (gameObject.transform.position.x + 2.5 >= playerCoords.x)) && ((gameObject.transform.position.y - 2.5 <= playerCoords.y) && (gameObject.transform.position.y + 2.5 >= playerCoords.y)))
        {
            player.SendMessage("damage", gameObject.name + ";" + damage);
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
