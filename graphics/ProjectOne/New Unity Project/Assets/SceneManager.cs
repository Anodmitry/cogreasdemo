using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public GameObject passableInfo;
    public void LoadScene (string scene)
    {
        Application.LoadLevel(scene);
    }
    public void LoadSceneMain()
    {
        DontDestroyOnLoad(passableInfo);
        Application.LoadLevel("Main");
    }
}
