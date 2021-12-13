using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleTriggerScript : MonoBehaviour
{
    public ParticleSystem collParticles;

    // Start is called before the first frame update
    void Start()
    {
        // collParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            collParticles.Play();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        collParticles.Play();
    }

    private void OnCollisionEnter(Collision other)
    {
        collParticles.Play();
    }
}
