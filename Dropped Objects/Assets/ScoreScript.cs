﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scorevalue = 0;
    //private float realtimepassed = 0.0f;
    Text score;


    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();
        scorevalue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // realtimepassed += Time.deltaTime;
        // scorevalue = (int)realtimepassed;
        score.text = "Score: " + scorevalue;
    }
}