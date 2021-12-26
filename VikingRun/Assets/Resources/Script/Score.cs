//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////counting the score the player get///////////////////////////////////////////////////////
//////////////////////////////////////////////////////counting the score the player get///////////////////////////////////////////////////////
//////////////////////////////////////////////////////counting the score the player get///////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    float startTime;
    float score;
    bool die;

    void Start()
    {
        scoreText = transform.GetComponent<Text>();
        startTime = Time.time;
        score = 0;
        die = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayMovement.start)
        {
            if (Time.time - startTime > 0.1 && !die)//if the game start and the viking does alive,then it will get a point per 0.1 second
            {
                score += 1;
                startTime = Time.time;
            }
            scoreText.text = score.ToString();
        }
        if (Input.GetKey(KeyCode.Escape))//press esc to leave the game
        {
            Application.Quit(0);
        }

    }

    public void Add(int p)//get 100 point when the viking get a coin
    {
        score += p;
    }
    public void Stop()//stop adding the score when the viking die
    {
        die = true;
        FinalScore.totalScore = score;
    }

}

