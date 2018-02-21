﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour {
    public float ExpTime = 0.3f;
    public GameObject explosion;
    public GameObject player;
    public int damage;
	void Start () {
        if (gameObject.name != "BombLitSprite")
            StartCoroutine(Boom());
    }
    IEnumerator Boom()
    {
        yield return new WaitForSeconds(ExpTime);
        Vector3 playerCoords = player.transform.position;
        if (((gameObject.transform.position.x-2.5 <= playerCoords.x) && (gameObject.transform.position.x + 2.5 >= playerCoords.x)) && ((gameObject.transform.position.y - 2.5 <= playerCoords.y) && (gameObject.transform.position.y + 2.5 >= playerCoords.y)))
            player.SendMessage("damage", gameObject.name + ";" + damage);
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
