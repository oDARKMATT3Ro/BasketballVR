using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    // Public variables
    public float maxTime = 60.0f;

    // Private variables
    private float levelTimer = 0.0f;

	// Use this for initialization
	void Start () {

        /// Sets the level timer to the max time
        levelTimer = maxTime;

    }
	
	// Update is called once per frame
	void Update () {

            if (levelTimer > 0) {

                levelTimer -= Time.deltaTime;
                Debug.Log(levelTimer);

                if (levelTimer < 0) {
                    NextScene();
                }

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
