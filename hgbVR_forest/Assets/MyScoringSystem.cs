﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScoringSystem : MonoBehaviour {

    public GameObject ScoreText;
    public static int theScore;

    void Update(){
        ScoreText.GetComponent<Text>().text = "collected: " + theScore;
    }
}

