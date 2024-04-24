using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TourCount;
using static MoneyCount;
using static PlayerScript;
using static TextActionJoueur1;
using static System.Math;


public class CountdownScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static float ButtonLeft = 1;
    public bool TimerOn = false;
    Text Countdown;
	public int tour = 1;
	[SerializeField] private GameObject GameOver;
	public AudioSource FinTour;

    void Start()
    {
        TimerOn = true;
        Countdown = GetComponent<Text> ();
		FinTour = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (TimerOn && Gamer1.ready && Gamer2.ready)
        {
            if (Gamer1.TimeLeft > 0)
            {
                Gamer1.TimeLeft -= Time.deltaTime;
                UpdateTimer();
            }
            /**else
            {
                if (Gamer1._button && Gamer2._button)
                {
                    Gamer1._button = false;
                    MoneyCount.CalCulus(Gamer1, "timer");
                    Gamer2._button = false;
                    MoneyCount.CalCulus(Gamer2, "timer");
                }
                else if (Gamer2._button)
                {
                    Gamer2._button = false;
                    MoneyCount.CalCulus(Gamer1, "timer");
                }
                else
                {
                       Gamer1._button = false;
                       MoneyCount.CalCulus(Gamer1, "timer");
                }
            }*/
        }
        
    }

    void UpdateTimer()
    {
        Countdown.text = $"{(int)(Gamer1.TimeLeft/Gamer1.nbCount)}";
        if (Gamer1.TimeLeft >= 80)
            Countdown.color = Color.green;
        else if (Gamer1.TimeLeft >= 40)
            Countdown.color = Color.yellow;
        else
            Countdown.color = Color.red;
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
