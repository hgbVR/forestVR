using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCanvasMenu : MonoBehaviour
{
    private Text titleComponent;

    // Start is called before the first frame update
    void Start()
    {
        titleComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        titleComponent.text = "Welcome to Forest of memories";
    }
}
