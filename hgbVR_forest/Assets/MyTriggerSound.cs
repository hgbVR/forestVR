using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTriggerSound : MonoBehaviour {

    public AudioSource playWorldSound;

    void OnTriggerEnter(Collider other){
        playWorldSound.Play();
    }
}
