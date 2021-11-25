using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyButtonHandler : MonoBehaviour
{
    public void SetText(string text)
    {
        Text txt = transform.Find("Start").GetComponent<Text>();
        txt.text = text;

    }
}
