using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    int countDownStartValue = 70;
    public Text timerUI;
    public GameManagerScript gameManager;
    private bool isOver;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1f);
        }
        else if(countDownStartValue <= 0 && !isOver)
        {
            isOver = true;
            gameManager.gameOver();
            timerUI.text = "GameOver!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
