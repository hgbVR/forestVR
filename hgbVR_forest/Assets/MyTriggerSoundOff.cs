using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTriggerSoundOff : MonoBehaviour
{

    public AudioSource playWorldSound;

    void OnTriggerEnter(Collider other)
    {
        playWorldSound.Stop();
    }
}