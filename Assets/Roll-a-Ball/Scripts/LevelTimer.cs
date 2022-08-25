using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    //Seconds
    public int timeLimit = 120;

    public Text timerText;

    private float timeElapsed = 0.0f;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        Debug.Log(timeElapsed);
        int timeRemaining = timeLimit - (int)timeElapsed;
        if (timeRemaining < 0)
        {
            timeRemaining = 0;

        }

       int minutesLeft = timeRemaining / 60;

       int secondsLeft = timeRemaining % 60;

       timerText.text = minutesLeft.ToString("00") + ":" + secondsLeft.ToString("00");
        //timerText.text = timeRemaining.ToString("00:00");
    }
}
