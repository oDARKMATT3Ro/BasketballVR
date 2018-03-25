using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballBounceSound : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {

        AudioSource audioSource = GetComponent<AudioSource>();
        if (collision.collider.gameObject.layer == 8)
        audioSource.Play();
        
    }


}
