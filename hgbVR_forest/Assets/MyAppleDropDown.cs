using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAppleDropDown : MonoBehaviour {

    void OnCollisionEnter(Collision thecollision){
        if(thecollision.gameObject.name == "neue Welt"){
            Debug.Log("Der Apfel ist auf den Waldboden gefallen.");
        }
        else{
            Debug.Log("Der Apfel ist noch nicht auf den Waldboden gefallen.");
        }
    }
}
