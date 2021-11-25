using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAppleDrop : MonoBehaviour
{

    void Start()
    {

    }

    void OnCollisionEnter(Collision thecollision)
    {
        if (thecollision.gameObject.name == "Waldboden")
        {
            Debug.Log("Hit the forestfloor");
        }
        else if (thecollision.gameObject.name == "Wall")
        {
            Debug.Log("Hit the wall");
        }
    }

    void Update()
    {

    }
}
