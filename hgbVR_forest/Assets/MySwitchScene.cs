using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySwitchScene : MonoBehaviour {

    public string ForestScene;

    void Start() {
        
    }

    
    void Update() {
        if (Input.GetKey("s")){
            Debug.Log("Switching to ForestScene");
            SceneManager.LoadScene(sceneBuildIndex: 0);
            SceneManager.LoadScene(sceneName: "ForestScene");
        }
    }
}
