using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TourCount;
using static MoneyCount;

public class CountdownScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeLeft = 101;
    public bool TimerOn = false;
    Text Countdown;
	public int tour = 1;

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
			if (tour != TourCount.TurnValues)
			{
				TimeLeft = 101;
				++tour;
			}
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 101;
                MoneyCount.CalCulus(MoneyCount.Gamer1, "timer");
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime -= 1;
        Countdown.text = $"{(int)currentTime}";
    }
}
