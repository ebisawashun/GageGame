using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SliderOne : MonoBehaviour
{
    public Slider slider;
    private bool maxValue;
    private bool isClicked;
    [SerializeField] float gageSpeedPulas = 0.05f;
    [SerializeField] float gageSpeed = 1.0f;
    [SerializeField] float perfectGage = 4.0f;
    [SerializeField] Text _scoreText = default;
    int _score = 0;
    private bool isStart;
    int scoreOne = 0;


    void Start()
    {
        slider.value = 0;
        maxValue = false;
        isClicked = false;
    }

    //public void Score()
    //{
    //    scoreOne=scoreOne;
    //    Debug.Log(scoreOne);
    //}

    // Update is called once per frame
    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString("00");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !isStart)
        {
            isStart = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && isStart)
        {
            isStart = false;
        }

        if (isStart)
        {

            if (Input.GetMouseButtonDown(0))
            {

                if (perfectGage < slider.value)
                {
                    gageSpeed = gageSpeed + gageSpeedPulas;
                    AddScore(1);
                }
                else
                {
                    isClicked = true;
                    scoreOne = _score;
                    Result();
                }
            }

            if (!isClicked)
            {
                if (slider.value == 5)
                {
                    maxValue = true;
                }

                if (slider.value == 0)
                {
                    maxValue = false;
                }



                if (maxValue)
                {
                    slider.value -= gageSpeed;
                }
                else
                {
                    slider.value += gageSpeed;
                }
                if (gageSpeed > 0.035)
                {
                    gageSpeed = 0.035f;
                }
            }
        }
        void Result()
        {
            scoreOne = _score;
        }
    }
}