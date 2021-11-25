using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScoringSystem : MonoBehaviour {

    public GameObject ScoreText;
    public int theScore;
    public AudioSource CollectSound;

    void OnTriggerEnter(Collider other){
        CollectSound.Play();
        theScore += 1;
        ScoreText.GetComponent<Text>().text = "Score: " + theScore;
        Destroy(gameObject);
    }

}
