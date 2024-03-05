using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TourCount;
using static MoneyCount;

public class CountdownScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static float ButtonLeft = 1;
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
            if (Gamer1.TimeLeft > 0)
            {
                Gamer1.TimeLeft -= Time.deltaTime;
                UpdateTimer(Gamer1.TimeLeft);
            }
            else
            {
                if (Gamer1._button && Gamer2._button)
                {
                    Gamer1._button = false;
                    MoneyCount.CalCulus(MoneyCount.Gamer1, "timer");
                    Gamer2._button = false;
                    MoneyCount.CalCulus(MoneyCount.Gamer2, "timer");
                }
                else if (Gamer2._button)
                {
                    Gamer2._button = false;
                    MoneyCount.CalCulus(MoneyCount.Gamer1, "timer");
                }
                else
                {
                       Gamer1._button = false;
                       MoneyCount.CalCulus(MoneyCount.Gamer1, "timer");
                }
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime -= 1;
        Countdown.text = $"{(int)(Gamer1.TimeLeft/Gamer1.nbCount)}";
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
