using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class CountdownScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeLeft;
    public bool TimerOn = false;
    Text Countdown;
    void Start()
    {
        TimerOn = true;
        Countdown = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                TimerOn = false;
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime -= 1;
        Countdown.text = $"{currentTime}";
    }
}
