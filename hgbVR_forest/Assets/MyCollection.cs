using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCollection : MonoBehaviour
{
    public AudioSource CollectSound;
    public static bool triggerState = false;

    void OnTriggerEnter(Collider other){
        triggerState = true;
        Debug.Log("OnTriggerEnter");
        CollectSound.Play();
        MyScoringSystem.theScore += 1;
        Destroy(gameObject);
    }
}
