//Viktoria Frank und Jürgen Ropp

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAppleDrop : MonoBehaviour
{

    public AudioSource CollectSound;

    public ParticleSystem Flare;

    void Start()
    {

    }

    void OnCollisionEnter(Collision thecollision)
    {
        Debug.Log("Collision");
        Flare.Play();
        Debug.Log(thecollision.gameObject.name);
        
    }

    void OnTriggerEnter(Collider thecollider)
    {
        Debug.Log(thecollider.gameObject.name);
        //hier den counter triggern
        if (thecollider.gameObject.name == "triggerCube")
        {
            Debug.Log("name works");
            playCollectionSound();
            MyScoringSystem.theScore += 1;
            Debug.Log("Count:" + MyScoringSystem.theScore);
            Flare.Play();
            //Flare.Emit(100);

        }
    }

    public void playCollectionSound()
    {
        CollectSound.Play();
    }

    void Update()
    {

    }
}
