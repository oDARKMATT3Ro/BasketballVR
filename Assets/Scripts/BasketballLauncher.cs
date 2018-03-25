using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballLauncher : MonoBehaviour {

    public GameObject basketballPrefab;
    public float ballSpeed = 5.0f;
    public Vector3 throwAngle = new Vector3(-25, 0, 0);

    private Quaternion quaternion;

	// Use this for initialization
	void Start () {
        quaternion = Quaternion.Euler(throwAngle);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {
            GameObject instance = Instantiate(basketballPrefab);
            instance.transform.position = this.transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * quaternion * Vector3.forward * ballSpeed;
        }
    }
}
