using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expire : MonoBehaviour {
    public float expireTime;
    public string cloneof;
    void Start()
    {
        if (gameObject.name != cloneof)
            StartCoroutine(fadeaway());
    }
    IEnumerator fadeaway()
    {
        yield return new WaitForSeconds(expireTime);
        Destroy(gameObject);
    }


}
