using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    // Called before Start
    private void Awake()
    {
        // Don't destroy the music when we load the next scene
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadFirstScene", 3f);
	}

    // Load the first scene
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
