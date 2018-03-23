using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetector : MonoBehaviour {

    public int goalValue = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision) {
        ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
        sk.IncrementScore(goalValue);
    }
}
