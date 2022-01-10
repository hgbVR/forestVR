//Viktoria Frank

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MyScoringSystem : MonoBehaviour {

    public GameObject ScoreText;
    public static int theScore;

    float currentTime;
    public GameObject currentTimeText;

    public int infoScreenTime;
    public GameObject introductionText;

    void Start()
    {
        currentTime = 0;
        
    }

    void Update(){
        ScoreText.GetComponent<Text>().text = "collected: " + theScore;

        currentTime = currentTime + Time.deltaTime;
        currentTimeText.GetComponent<Text>().text = "Time: " + Math.Round(currentTime);

        if (currentTime > infoScreenTime)
        {
            introductionText.SetActive(false);
        }

        //TimeSpan time = TimeSpan.FromSeconds(currentTime);
        //currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();        
    }
}

