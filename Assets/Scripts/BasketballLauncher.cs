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

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            GameObject instance = Instantiate(basketballPrefab);
            instance.transform.position = this.transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
        }
    }
}
