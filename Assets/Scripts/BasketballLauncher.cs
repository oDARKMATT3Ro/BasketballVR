using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballLauncher : MonoBehaviour {

    public GameObject basketballPrefab;
    public float ballSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float speed = 5.0f;

        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject instance = Instantiate(basketballPrefab);
            instance.transform.position = this.transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * ballSpeed;
        }
    }
}
