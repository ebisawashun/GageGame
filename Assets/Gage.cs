using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    [SerializeField] int m_life = 3;
    [SerializeField] private AudioClip sound;
    private AudioSource audio;
    private bool isStart;

    void Start()
    {
        slider.value = 0;
        maxValue = false;
        isClicked = false;
        audio = gameObject.AddComponent<AudioSource>();
    }


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
        else if (Input.GetKeyDown(KeyCode.Space) && isStart)
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
                    m_life -= 1;
                    audio.PlayOneShot(sound);

                    if (m_life <= 0)
                    {
                        Debug.Log("end");
                        SceneManager.LoadScene("GameClear");
                    }
                }
                else
                {
                    isClicked = true;
                    SceneManager.LoadScene("GameOver");
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
}