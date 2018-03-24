using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour {

    LevelManager levelManager;
    Text text;

	// Use this for initialization
	void Start () {

        levelManager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

        text.text = "Shot Clock: " + levelManager.levelTimer + " seconds";

	}

}
