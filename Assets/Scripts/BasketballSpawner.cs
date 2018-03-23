using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballSpawner : MonoBehaviour {

    public GameObject basketballPrefab;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        float speed = 5.0f;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            GameObject instance = Instantiate(basketballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            GameObject instance = Instantiate(basketballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * speed;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            GameObject instance = Instantiate(basketballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            GameObject instance = Instantiate(basketballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * speed;
        }

    }

}
