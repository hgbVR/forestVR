using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyExplantation : MonoBehaviour
{
    private Text explainComponent;


    // Start is called before the first frame update
    void Start()
    {
        explainComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        explainComponent.text = "Explore the forest, grap some objects to collect and identify them.";
    }
}
