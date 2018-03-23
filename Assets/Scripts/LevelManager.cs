using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            NextScene();
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            ResetScene();
        }

	}

    public void NextScene() {

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);

    }

    public void ResetScene() {

        SceneManager.LoadScene("00_Menu");

    }

    public void QuitGame() {

        // Quit the application inside Unity Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        // Quit the application
        Application.Quit();

    }

}
