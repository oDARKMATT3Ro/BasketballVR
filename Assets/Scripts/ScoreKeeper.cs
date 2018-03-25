using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    static ScoreKeeper instance = null;

    public int score = 0;

    void Awake() {

        Debug.Log("Score keeper " + GetInstanceID() + " is awake.");

        if (instance != null) {

            Destroy(gameObject);
            Debug.Log("Duplicate score keeper detected. Destroying second instance.");
        } else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementScore(int amount) {

        score += amount;
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Debug.Log("Your scored a goal. Your current score is: " + score + ".");

    }

    public void ResetScore() {

        score = 0;
        Debug.Log("The score has been reset. Your current score is: " + score + ".");

    }

}
