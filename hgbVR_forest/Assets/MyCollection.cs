using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCollection : MonoBehaviour
{
    public AudioSource CollectSound;
    public static bool triggerState = false;

    


    /*
    private void OnCollisionEnter(Collision collision)
    {
        triggerState = true;
        Debug.Log("OnTriggerEnter");
        playCollectionSound();
        MyScoringSystem.theScore += 1;
        Destroy(gameObject);
    }

    */

    public void playCollectionSound()
    {
        CollectSound.Play();
    }
    

    
    void OnTriggerEnter(Collider other){
        triggerState = true;
        Debug.Log("OnTriggerEnter");
        Debug.Log(gameObject.name);
        playCollectionSound();
        MyScoringSystem.theScore += 1;
        //Destroy(gameObject);

        triggerState = false;
    }
    
}
