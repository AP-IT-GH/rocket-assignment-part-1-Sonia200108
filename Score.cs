using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreUI;
    public int score;


    public void OnTriggerEnter(Collider other)
    {
        //scoreUI.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(scoreUI.GetComponent<Text>.text) + score);
    }
}
