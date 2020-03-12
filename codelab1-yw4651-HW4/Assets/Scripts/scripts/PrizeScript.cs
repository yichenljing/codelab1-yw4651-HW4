﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PrizeScript : MonoBehaviour
{
    public Color colorA;
    public Color colorB;
    public Text ScoreText;


    public static int currentLevel = 0;
    public int targetScore;
 

    // Start is called before the first frame update
    void Start()
    {
        targetScore = GameManager.instance.Score * 2 + 2; //increase the target score every level
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text =GameManager.instance.Score.ToString("0");  //show current scores
    }

    private void OnCollisionEnter2D(Collision2D collision) //If another GameObject with a 2D Collider on it hits this GameObject's collider
    {
        if (transform.GetComponent<SpriteRenderer>().color != colorB) //when the prize is green on collison
      
        {

            GameManager.instance.Score++; //increase the player's score using the Singleton!
            Debug.Log("Score: " + GameManager.instance.Score);  //print the score to console, using the Singleton
            transform.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4)); //teleport to a random location

            if (GameManager.instance.Score > targetScore)  //if the current score >  the targetScore
            {
                currentLevel++; //increate the level number
                SceneManager.LoadScene(currentLevel); //go to the next level
            }

        }

        else if (transform.GetComponent<SpriteRenderer>().color != colorA) //when the prize is purple on collison
        {

           
            Debug.Log("Score: " + GameManager.instance.Score); //print the score to console, using the Singleton
            transform.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4)); //teleport to a random location

        }

    }
}
