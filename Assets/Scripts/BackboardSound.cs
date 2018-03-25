using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackboardSound : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }
}
