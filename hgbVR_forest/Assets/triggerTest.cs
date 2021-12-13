using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTest : MonoBehaviour
{

    //Trigger wenn isTrigger ist ein beim anderen

    //sonst collisionEnter


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ball collision");
    }
}

