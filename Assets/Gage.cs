using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    public Slider slider;
    private bool maxValue;
    private bool isClicked;
    [SerializeField] float GageSpeed = 1.0f;
    [SerializeField] float PerfectGage = 4.0f;

    void Start()
    {
        slider.value = 0;
        maxValue = false;
        isClicked = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;
            if (PerfectGage < slider.value)
            {
                Debug.Log("Å‚");
                
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
                slider.value -= GageSpeed;
            }
            else
            {
                slider.value += GageSpeed;
            }
        }
    }
}