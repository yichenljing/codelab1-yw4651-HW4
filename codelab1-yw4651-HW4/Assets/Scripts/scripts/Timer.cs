using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    private float currentTime = 0f; // the time now display
    public float startingTime = 0f;  //play time

    public Text countdownText;
    public static Timer instance;
   

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
       currentTime += 1 * Time.deltaTime; //

       countdownText.text = currentTime.ToString("0");

       if(currentTime <= 0)
        {

            currentTime =0;

        }


        }
    }

