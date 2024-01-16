using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TourCount;
using static MoneyCount;

public class CountdownScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static float ButtonLeft = 3;
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
                Gamer1.TimeLeft = 100;
				++tour;
			}
            if (Gamer1.TimeLeft > 0)
            {
                Gamer1.TimeLeft -= Time.deltaTime;
                UpdateTimer(Gamer1.TimeLeft);
            }
            else
            {
                Gamer1.TimeLeft = 100;
                MoneyCount.CalCulus(MoneyCount.Gamer1, "timer");
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime -= 1;
        Countdown.text = $"{(int)Gamer1.TimeLeft}";
    }

    public static void UpdateTimeButton(PlayerClass gamer)
    {
        gamer._button = false;
        while (ButtonLeft > 0)
        {
            ButtonLeft -= Time.deltaTime;
            ButtonLeft -= 1;
        }
        ButtonLeft = 3;
        gamer._button = true;
    }
}
