using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

    public Text passableInfo;
    public void LoadScene (string scene)
    {
        Application.LoadLevel(scene);
    }
    public void LoadSceneMain()
    {
        passableInfo.text = "Script=0; " + passableInfo.text;
        DontDestroyOnLoad(passableInfo);
        Application.LoadLevel("GameScene");
    }
    public void LoadSceneMainScripted()
    {
        passableInfo.text = "Script=1; " + passableInfo.text;
        DontDestroyOnLoad(passableInfo);
        Application.LoadLevel("GameScene");
    }
}
