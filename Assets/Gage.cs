using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    public Slider slider;
    private bool maxValue;
    private bool isClicked;
    [SerializeField] float gageSpeedPulas = 0.05f;
    [SerializeField] float gageSpeed = 1.0f;
    [SerializeField] float perfectGage = 4.0f;
    [SerializeField] Text _scoreText = default;
    int _score = 0;

    void Start()
    {
        slider.value = 0;
        maxValue = false;
        isClicked = false;
    }


    // Update is called once per frame
    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString("00");
    }

    void Update()
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
        }

    }
}