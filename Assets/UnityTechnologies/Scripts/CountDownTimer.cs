using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    int countDownStartValue = 5;
    public Text timerUI;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            timerUI.text = "Timer : " + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1f);
        }
        else
        {
            timerUI.text = "GameOver!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
