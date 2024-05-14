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

    public void CalCulus(PlayerClass gamer)
    {
        System.Random aleatoire = new System.Random();
        double attractive = gamer._stat["Attractivité"];
        double client = gamer._stat["Clientèle"];
        int nb_client = aleatoire.Next((int)Round(client / 2, 0), (int)Round(client * 2, 0));
        int key;
        if (gamer._turn)
        {
			gamer._turn = false;
            for (int i = 0; i < nb_client*(gamer._stat["Magasin"]); ++i)
            {

                if (aleatoire.Next(0, 101) < attractive)
                {
                    key = aleatoire.Next(0, gamer._items.Count);
					if (gamer._items[key] != "NaN")
					{
                    	(int Quantity, double price, bool possible, double quali, int tour) = gamer._marchandise[gamer._items[key]];
						if (Quantity > 0)
						{
                    		gamer._marchandise[gamer._items[key]] = (--Quantity, price, possible, quali, tour);
							RemovePerime(gamer, key);
							if (gamer.promo)
								gamer.sum += price*0.8 + 0.1*price*(quali-1);
							else
                    			gamer.sum += price + 0.1*price*(quali-1);
							Vente(gamer == Gamer1, price, quali);
						}
					}
                }
            }
			if (TourCount.TurnValues % 4 == 0)
          	{
             (double benef, double attract, double chance) =
                evenement._event[evenement._eventComing[TourCount.TurnValues/4 - 1]];
             gamer._stat["Attractivité"] *= attract;
             gamer.sum *= benef;
			 CooefficientOpponent(gamer == Gamer1, attract, gamer.sum, benef);
          	}

			for (int i = 0; i < 12; ++i)
				Perime(gamer, i);
            gamer.AddMoney(gamer.sum);
			gamer._mounth += gamer.sum;
			AjoutOpponent(gamer.sum, gamer == Gamer1);
			bool b = false;
			if (TourCount.TurnValues % 4 == 0)
			{
				if (gamer._mounth < 4000)
					gamer._mounth = 4000;
				b = (!gamer.AddMoney(-gamer._mounth/4) || !gamer.AddMoney(-gamer._stat["Employé"]*gamer._stat["Salaire"]));
				if (b)
				{
					GameOver.SetActive(true);
				}
				else
					{
						gamer._mounth = 0;
						RetraitOpponent(gamer._mounth/4+gamer._stat["Employé"]*gamer._stat["Salaire"], gamer == Gamer1);
					}
			}
			if (Gamer1._turn == false && Gamer2._turn == false)
			{
				Gamer1.TimeLeft = 120*Gamer1.nbCount;
				TourCount.AddTurn("");
				Gamer1._turn = true;
				Gamer2._turn = true;
				Gamer1._button = true;
				Gamer2._button = true;
				Gamer1.sum = 0;
				Gamer2.sum = 0;
				FinTour.Play();
				RetourOpponent();
				if (!(TourCount.TurnValues > TourCount.MaxTurn))
					AI.Act10();
			}
			if (TourCount.TurnValues > TourCount.MaxTurn || b)
			{
				Player1Script.move = false;
				GameOver.SetActive(true);
			}
        }
    }

	public void Perime(PlayerClass gamer, int key)
	{
		if (gamer._items[key] != "NaN")
		{
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
			int j = 0;
			switch (key)
			{
				case 0:
				  	gamer.Perime1.Add(gamer.More1);
				  	if (gamer.Perime1.Count > tour)
					{
						j = gamer.Perime1[0];
						gamer.Perime1.RemoveAt(0);
					}
					gamer.More1 = 0;
				  	break;
				case 1:
					gamer.Perime2.Add(gamer.More2);
				  	if (gamer.Perime2.Count > tour)
					{
						j = gamer.Perime2[0];
						gamer.Perime2.RemoveAt(0);
					}
					gamer.More2 = 0;
					break;
				case 2:
					gamer.Perime3.Add(gamer.More3);
				  	if (gamer.Perime3.Count > tour)
					{
						j = gamer.Perime3[0];
						gamer.Perime3.RemoveAt(0);
					}
					gamer.More3 = 0;
					break;
				case 3:
					gamer.Perime4.Add(gamer.More4);
				  	if (gamer.Perime4.Count > tour)
					{
						j = gamer.Perime4[0];
						gamer.Perime4.RemoveAt(0);
					}
					gamer.More4 = 0;
					break;
				case 4:
					gamer.Perime5.Add(gamer.More5);
				  	if (gamer.Perime5.Count > tour)
					{
						j = gamer.Perime5[0];
						gamer.Perime5.RemoveAt(0);
					}
					gamer.More5 = 0;
					break;
				case 5:
					gamer.Perime6.Add(gamer.More6);
				  	if (gamer.Perime6.Count > tour)
					{
						j = gamer.Perime6[0];
						gamer.Perime6.RemoveAt(0);
					}
					gamer.More6 = 0;
					break;
				case 6:
					gamer.Perime7.Add(gamer.More7);
				  	if (gamer.Perime7.Count > tour)
					{
						j = gamer.Perime7[0];
						gamer.Perime7.RemoveAt(0);
					}
					gamer.More7 = 0;
					break;
				case 7:
					gamer.Perime8.Add(gamer.More8);
				  	if (gamer.Perime8.Count > tour)
					{
						j = gamer.Perime8[0];
						gamer.Perime8.RemoveAt(0);
					}
					gamer.More8 = 0;
					break;
				case 8:
					gamer.Perime9.Add(gamer.More9);
				  	if (gamer.Perime9.Count > tour)
					{
						j = gamer.Perime9[0];
						gamer.Perime9.RemoveAt(0);
					}
					gamer.More9 = 0;
					break;
				case 9:
					gamer.Perime10.Add(gamer.More10);
				  	if (gamer.Perime10.Count > tour)
					{
						j = gamer.Perime10[0];
						gamer.Perime10.RemoveAt(0);
					}
					gamer.More10 = 0;
					break;
				case 10:
					gamer.Perime11.Add(gamer.More11);
				  	if (gamer.Perime11.Count > tour)
					{
						j = gamer.Perime11[0];
						gamer.Perime11.RemoveAt(0);
					}
					gamer.More11 = 0;
					break;
				case 11:
				  	gamer.Perime12.Add(gamer.More12);
				  	if (gamer.Perime12.Count > tour)
					{
						j = gamer.Perime12[0];
						gamer.Perime12.RemoveAt(0);
					}
					gamer.More12 = 0;
					break;
			}
			Quantity -= j;
			if (Quantity < 0)
				Quantity = 0;
			gamer._marchandise[gamer._items[key]] = (Quantity, price, possible, promo, tour);
		
		}
		if (gamer == Gamer1)
			PerimeOpponent(key, true);
		else
			PerimeOpponent(key, false);
	}

	public void PerimeOpponent(int p, bool joueur1)
	{
		
			OpponentPerimeClientRpC(p, joueur1);
	
	}
	
	private void OpponentPerimeClientRpC(int key, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer._items[key] != "NaN")
		{
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
			int j = 0;
			switch (key)
			{
				case 0:
				  	gamer.Perime1.Add(gamer.More1);
				  	if (gamer.Perime1.Count > tour)
					{
						j = gamer.Perime1[0];
						gamer.Perime1.RemoveAt(0);
					}
					gamer.More1 = 0;
				  	break;
				case 1:
					gamer.Perime2.Add(gamer.More2);
				  	if (gamer.Perime2.Count > tour)
					{
						j = gamer.Perime2[0];
						gamer.Perime2.RemoveAt(0);
					}
					gamer.More2 = 0;
					break;
				case 2:
					gamer.Perime3.Add(gamer.More3);
				  	if (gamer.Perime3.Count > tour)
					{
						j = gamer.Perime3[0];
						gamer.Perime3.RemoveAt(0);
					}
					gamer.More3 = 0;
					break;
				case 3:
					gamer.Perime4.Add(gamer.More4);
				  	if (gamer.Perime4.Count > tour)
					{
						j = gamer.Perime4[0];
						gamer.Perime4.RemoveAt(0);
					}
					gamer.More4 = 0;
					break;
				case 4:
					gamer.Perime5.Add(gamer.More5);
				  	if (gamer.Perime5.Count > tour)
					{
						j = gamer.Perime5[0];
						gamer.Perime5.RemoveAt(0);
					}
					gamer.More5 = 0;
					break;
				case 5:
					gamer.Perime6.Add(gamer.More6);
				  	if (gamer.Perime6.Count > tour)
					{
						j = gamer.Perime6[0];
						gamer.Perime6.RemoveAt(0);
					}
					gamer.More6 = 0;
					break;
				case 6:
					gamer.Perime7.Add(gamer.More7);
				  	if (gamer.Perime7.Count > tour)
					{
						j = gamer.Perime7[0];
						gamer.Perime7.RemoveAt(0);
					}
					gamer.More7 = 0;
					break;
				case 7:
					gamer.Perime8.Add(gamer.More8);
				  	if (gamer.Perime8.Count > tour)
					{
						j = gamer.Perime8[0];
						gamer.Perime8.RemoveAt(0);
					}
					gamer.More8 = 0;
					break;
				case 8:
					gamer.Perime9.Add(gamer.More9);
				  	if (gamer.Perime9.Count > tour)
					{
						j = gamer.Perime9[0];
						gamer.Perime9.RemoveAt(0);
					}
					gamer.More9 = 0;
					break;
				case 9:
					gamer.Perime10.Add(gamer.More10);
				  	if (gamer.Perime10.Count > tour)
					{
						j = gamer.Perime10[0];
						gamer.Perime10.RemoveAt(0);
					}
					gamer.More10 = 0;
					break;
				case 10:
					gamer.Perime11.Add(gamer.More11);
				  	if (gamer.Perime11.Count > tour)
					{
						j = gamer.Perime11[0];
						gamer.Perime11.RemoveAt(0);
					}
					gamer.More11 = 0;
					break;
				case 11:
				  	gamer.Perime12.Add(gamer.More12);
				  	if (gamer.Perime12.Count > tour)
					{
						j = gamer.Perime12[0];
						gamer.Perime12.RemoveAt(0);
					}
					gamer.More12 = 0;
					break;
			}
			Quantity -= j;
			if (Quantity < 0)
				Quantity = 0;
			gamer._marchandise[gamer._items[key]] = (Quantity, price, possible, promo, tour);
		
		}
	}


	private void OpponentPerimeServerRpC(int key, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer._items[key] != "NaN")
		{
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
			int j = 0;
			switch (key)
			{
				case 0:
				  	gamer.Perime1.Add(gamer.More1);
				  	if (gamer.Perime1.Count > tour)
					{
						j = gamer.Perime1[0];
						gamer.Perime1.RemoveAt(0);
					}
					gamer.More1 = 0;
				  	break;
				case 1:
					gamer.Perime2.Add(gamer.More2);
				  	if (gamer.Perime2.Count > tour)
					{
						j = gamer.Perime2[0];
						gamer.Perime2.RemoveAt(0);
					}
					gamer.More2 = 0;
					break;
				case 2:
					gamer.Perime3.Add(gamer.More3);
				  	if (gamer.Perime3.Count > tour)
					{
						j = gamer.Perime3[0];
						gamer.Perime3.RemoveAt(0);
					}
					gamer.More3 = 0;
					break;
				case 3:
					gamer.Perime4.Add(gamer.More4);
				  	if (gamer.Perime4.Count > tour)
					{
						j = gamer.Perime4[0];
						gamer.Perime4.RemoveAt(0);
					}
					gamer.More4 = 0;
					break;
				case 4:
					gamer.Perime5.Add(gamer.More5);
				  	if (gamer.Perime5.Count > tour)
					{
						j = gamer.Perime5[0];
						gamer.Perime5.RemoveAt(0);
					}
					gamer.More5 = 0;
					break;
				case 5:
					gamer.Perime6.Add(gamer.More6);
				  	if (gamer.Perime6.Count > tour)
					{
						j = gamer.Perime6[0];
						gamer.Perime6.RemoveAt(0);
					}
					gamer.More6 = 0;
					break;
				case 6:
					gamer.Perime7.Add(gamer.More7);
				  	if (gamer.Perime7.Count > tour)
					{
						j = gamer.Perime7[0];
						gamer.Perime7.RemoveAt(0);
					}
					gamer.More7 = 0;
					break;
				case 7:
					gamer.Perime8.Add(gamer.More8);
				  	if (gamer.Perime8.Count > tour)
					{
						j = gamer.Perime8[0];
						gamer.Perime8.RemoveAt(0);
					}
					gamer.More8 = 0;
					break;
				case 8:
					gamer.Perime9.Add(gamer.More9);
				  	if (gamer.Perime9.Count > tour)
					{
						j = gamer.Perime9[0];
						gamer.Perime9.RemoveAt(0);
					}
					gamer.More9 = 0;
					break;
				case 9:
					gamer.Perime10.Add(gamer.More10);
				  	if (gamer.Perime10.Count > tour)
					{
						j = gamer.Perime10[0];
						gamer.Perime10.RemoveAt(0);
					}
					gamer.More10 = 0;
					break;
				case 10:
					gamer.Perime11.Add(gamer.More11);
				  	if (gamer.Perime11.Count > tour)
					{
						j = gamer.Perime11[0];
						gamer.Perime11.RemoveAt(0);
					}
					gamer.More11 = 0;
					break;
				case 11:
				  	gamer.Perime12.Add(gamer.More12);
				  	if (gamer.Perime12.Count > tour)
					{
						j = gamer.Perime12[0];
						gamer.Perime12.RemoveAt(0);
					}
					gamer.More12 = 0;
					break;
			}
			Quantity -= j;
			if (Quantity < 0)
				Quantity = 0;
			gamer._marchandise[gamer._items[key]] = (Quantity, price, possible, promo, tour);
		
		}
	}


	public void RemovePerime(PlayerClass gamer, int key)
	{
			switch (key)
			{
				case 0:
				  	if (gamer.Perime1.Count != 0 && gamer.Perime1[0] != 0)
						{
							--gamer.Perime1[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime1.Count == 0)
						return;
					else
					{
						gamer.Perime1.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 1:
					if (gamer.Perime2.Count != 0 && gamer.Perime2[0] != 0)
						{
							--gamer.Perime2[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}

					else if (gamer.Perime2.Count == 0)
						return;
					else
					{
						gamer.Perime2.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 2:
					if (gamer.Perime3.Count != 0 && gamer.Perime3[0] != 0)
						{
							--gamer.Perime3[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime3.Count == 0)
						return;
					else
					{
						gamer.Perime3.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 3:
					if (gamer.Perime4.Count != 0 && gamer.Perime4[0] != 0)
						{
							--gamer.Perime4[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime4.Count == 0)
						return;
					else
					{
						gamer.Perime4.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 4:
					if (gamer.Perime5.Count != 0 && gamer.Perime5[0] != 0)
						{
							--gamer.Perime5[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime5.Count == 0)
						return;
					else
					{
						gamer.Perime5.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 5:
					if (gamer.Perime6.Count != 0 && gamer.Perime6[0] != 0)
						{
							--gamer.Perime6[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime6.Count == 0)
						return;
					else
					{
						gamer.Perime6.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 6:
					if (gamer.Perime7.Count != 0 && gamer.Perime7[0] != 0)
						{
							--gamer.Perime7[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime7.Count == 0)
						return;
					else
					{
						gamer.Perime7.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 7:
					if (gamer.Perime8.Count != 0 && gamer.Perime8[0] != 0)
						{
							--gamer.Perime8[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime8.Count == 0)
						return;
					else
					{
						gamer.Perime8.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 8:
					if (gamer.Perime9.Count != 0 && gamer.Perime9[0] != 0)
						{
							--gamer.Perime9[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime9.Count == 0)
						return;
					else
					{
						gamer.Perime9.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 9:
					if (gamer.Perime10.Count != 0 && gamer.Perime10[0] != 0)
						{
							--gamer.Perime10[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime10.Count == 0)
						return;
					else
					{
						gamer.Perime10.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 10:
					if (gamer.Perime11.Count != 0 && gamer.Perime11[0] != 0)
						{
							--gamer.Perime11[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime11.Count == 0)
						return;
					else
					{
						gamer.Perime11.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
				case 11:
				  	if (gamer.Perime12.Count != 0 && gamer.Perime12[0] != 0)
						{
							--gamer.Perime12[0];
							if (gamer == Gamer1)
								RemovePerimeOpponent(key, true);
							else
								RemovePerimeOpponent(key, false);
						}
					else if (gamer.Perime12.Count == 0)
						return;
					else
					{
						gamer.Perime12.RemoveAt(0);
						RemovePerime(gamer, key);
						if (gamer == Gamer1)
								RemovePerimeOpponentR(key, true);
							else
								RemovePerimeOpponentR(key, false);
					}
				  	break;
			}
	}

	public void RemovePerimeOpponent(int p, bool joueur1)
	{
	
			OpponentRemovePerimeClientRpC(p, joueur1);
	
	}
	
	private void OpponentRemovePerimeClientRpC(int key, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
			(int Quantity, double price, bool possible, double quali, int tour) = gamer._marchandise[gamer._items[key]];
		gamer._marchandise[gamer._items[key]] = (--Quantity, price, possible, quali, tour);
		switch(key)
		{
			case 0:
				--gamer.Perime1[0];
				break;
			case 1:
				--gamer.Perime2[0];
				break;
			case 2:
				--gamer.Perime3[0];
				break;
			case 3:
				--gamer.Perime4[0];
				break;
			case 4:
				--gamer.Perime5[0];
				break;
			case 5:
				--gamer.Perime6[0];
				break;
			case 6:
				--gamer.Perime7[0];
				break;
			case 7:
				--gamer.Perime8[0];
				break;
			case 8:
				--gamer.Perime9[0];
				break;
			case 9:
				--gamer.Perime10[0];
				break;
			case 10:
				--gamer.Perime11[0];
				break;
			case 11:
				--gamer.Perime12[0];
				break;
		}
	}

	private void OpponentRemovePerimeServerRpC(int p, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
			(int Quantity, double price, bool possible, double quali, int tour) = gamer._marchandise[gamer._items[p]];
		gamer._marchandise[gamer._items[p]] = (--Quantity, price, possible, quali, tour);
		switch(p)
		{
			case 0:
				--gamer.Perime1[0];
				break;
			case 1:
				--gamer.Perime2[0];
				break;
			case 2:
				--gamer.Perime3[0];
				break;
			case 3:
				--gamer.Perime4[0];
				break;
			case 4:
				--gamer.Perime5[0];
				break;
			case 5:
				--gamer.Perime6[0];
				break;
			case 6:
				--gamer.Perime7[0];
				break;
			case 7:
				--gamer.Perime8[0];
				break;
			case 8:
				--gamer.Perime9[0];
				break;
			case 9:
				--gamer.Perime10[0];
				break;
			case 10:
				--gamer.Perime11[0];
				break;
			case 11:
				--gamer.Perime12[0];
				break;
		}
	}

	public void RemovePerimeOpponentR(int p, bool joueur1)
	{
		
			OpponentRemovePerimeClientRpCR(p, joueur1);
		
	}
	
	private void OpponentRemovePerimeClientRpCR(int p, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		switch(p)
		{
			case 0:
				gamer.Perime1.RemoveAt(0);
				break;
			case 1:
				gamer.Perime2.RemoveAt(0);
				break;
			case 2:
				gamer.Perime3.RemoveAt(0);
				break;
			case 3:
				gamer.Perime4.RemoveAt(0);
				break;
			case 4:
				gamer.Perime5.RemoveAt(0);
				break;
			case 5:
				gamer.Perime6.RemoveAt(0);
				break;
			case 6:
				gamer.Perime7.RemoveAt(0);
				break;
			case 7:
				gamer.Perime8.RemoveAt(0);
				break;
			case 8:
				gamer.Perime9.RemoveAt(0);
				break;
			case 9:
				gamer.Perime10.RemoveAt(0);
				break;
			case 10:
				gamer.Perime11.RemoveAt(0);
				break;
			case 11:
				gamer.Perime12.RemoveAt(0);
				break;
		}
	}
	
	private void OpponentRemovePerimeServerRpCR(int p, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		switch(p)
		{
			case 0:
				--gamer.Perime1[0];
				break;
			case 1:
				--gamer.Perime2[0];
				break;
			case 2:
				--gamer.Perime3[0];
				break;
			case 3:
				--gamer.Perime4[0];
				break;
			case 4:
				--gamer.Perime5[0];
				break;
			case 5:
				--gamer.Perime6[0];
				break;
			case 6:
				--gamer.Perime7[0];
				break;
			case 7:
				--gamer.Perime8[0];
				break;
			case 8:
				--gamer.Perime9[0];
				break;
			case 9:
				--gamer.Perime10[0];
				break;
			case 10:
				--gamer.Perime11[0];
				break;
			case 11:
				--gamer.Perime12[0];
				break;
		}
	}

	public void Vente(bool joueur1, double price, double quali)
	{
		
			VenteClientRpC(joueur1, price, quali);
	
	}


	private void VenteClientRpC(bool joueur1, double price, double quali)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer.promo)
			gamer.sum += price*0.8 + 0.1*price*(quali-1);
		else
            gamer.sum += price + 0.1*price*(quali-1);
	}
	
	private void VenteServerRpC(bool joueur1, double price, double quali)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer.promo)
			gamer.sum += price*0.8 + 0.1*price*(quali-1);
		else
            gamer.sum += price + 0.1*price*(quali-1);
	}
	public void CooefficientOpponent(bool joueur1, double attract, double sum, double benef)
	{
	
			CooefficientOpponentClientRpC(joueur1, attract, sum, benef);
	
	}


	private void CooefficientOpponentClientRpC(bool joueur1, double attract, double sum, double benef)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer._stat["Attractivité"] *= attract;
             gamer.sum *= benef;
	}

	private void CooefficientOpponentServerRpC(bool joueur1, double attract, double sum, double benef)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer._stat["Attractivité"] *= attract;
             gamer.sum *= benef;
	}
	public void RetourOpponent()
	{
		
			RetourOpponentClientRpC();
		
	}
	
	private void RetourOpponentClientRpC()
	{
		Gamer1.TimeLeft = 100*Gamer1.nbCount;
				TourCount.AddTurn("");
		Gamer1._turn = true;
				Gamer2._turn = true;
				Gamer1._button = true;
				Gamer2._button = true;
				Gamer1.sum = 0;
				Gamer2.sum = 0;
		
	}
	
	private void RetourOpponentServerRpC()
	{
		Gamer1.TimeLeft = 100*Gamer1.nbCount;
				TourCount.AddTurn("");
		Gamer1._turn = true;
				Gamer2._turn = true;
				Gamer1._button = true;
				Gamer2._button = true;
				Gamer1.sum = 0;
				Gamer2.sum = 0;
	}
	public void RetraitOpponent(double sum, bool joueur1)
	{
	
			RetraitOpponentClientRpC(sum, joueur1);
	
	}
	
	private void RetraitOpponentClientRpC(double sum, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer.AddMoney(-sum);
		gamer._mounth = 0;
		
	}
	
	private void RetraitOpponentServerRpC(double sum, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer.AddMoney(-sum);
		gamer._mounth = 0;
	}
	public void AjoutOpponent(double sum, bool joueur1)
	{
		
			AjoutOpponentClientRpC(sum, joueur1);
	
	}
	
	private void AjoutOpponentClientRpC(double sum, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer.AddMoney(sum);
		gamer._mounth += sum;
		
	}

	private void AjoutOpponentServerRpC(double sum, bool joueur1)
	{
		PlayerClass gamer;
		if (joueur1)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer.AddMoney(sum);
		gamer._mounth += sum;
	}
}
