using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimSound : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }
}
