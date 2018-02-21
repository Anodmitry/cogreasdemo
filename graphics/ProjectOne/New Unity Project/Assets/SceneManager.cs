using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

	public void LoadScene (string scene)
    {
        Debug.Log(scene);
        Application.LoadLevel(scene);
    }
}
