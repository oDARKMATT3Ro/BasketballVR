using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

    ScoreKeeperAbsorber scoreKeeperAbsorber;
    Text text;

    // Use this for initialization
    void Start() {

        scoreKeeperAbsorber = FindObjectOfType<ScoreKeeperAbsorber>();
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update() {

        text.text = "Score: " + scoreKeeperAbsorber.score;
    }

}
