using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCollisionName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void OnCollisionEnter(Collision thecollision)
    {
        Debug.Log("Collision");
        Debug.Log(thecollision.gameObject.name);

    }
    */

    void OnTriggerEnter(Collider thecollider)
    {
        Debug.Log("triggerEnter");
        Debug.Log(thecollider.gameObject.name);


        //hier den counter triggern

        /*
        if (thecollider.gameObject.tag == "triggerCube")
        {
            Debug.Log("tagging works");            
           

        }
        */
    }

}
