using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static TextGameOver;


public class MoneyCount : MonoBehaviour
{
    public static PlayerClass Gamer1 = new Primeur("Primeur");
	public static PlayerClass Gamer2 = new Boucherie("Boucher");
	public static Evenement evenement;
    Text MoneyInformation;
    // Start is called before the first frame update
    void Start()
    {
		evenement = new Evenement();
        MoneyInformation = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyInformation.text = $"{Math.Round(Gamer1._money, 2)} $";
    }

	public static void Perime(PlayerClass gamer, int key)
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
				  	break;
				case 1:
					gamer.Perime2.Add(gamer.More2);
				  	if (gamer.Perime2.Count > tour)
					{
						j = gamer.Perime2[0];
						gamer.Perime2.RemoveAt(0);
					}
					break;
				case 2:
					gamer.Perime3.Add(gamer.More3);
				  	if (gamer.Perime3.Count > tour)
					{
						j = gamer.Perime3[0];
						gamer.Perime3.RemoveAt(0);
					}
					break;
				case 3:
					gamer.Perime4.Add(gamer.More4);
				  	if (gamer.Perime4.Count > tour)
					{
						j = gamer.Perime4[0];
						gamer.Perime4.RemoveAt(0);
					}
					break;
				case 4:
					gamer.Perime5.Add(gamer.More5);
				  	if (gamer.Perime5.Count > tour)
					{
						j = gamer.Perime5[0];
						gamer.Perime5.RemoveAt(0);
					}
					break;
				case 5:
					gamer.Perime6.Add(gamer.More6);
				  	if (gamer.Perime6.Count > tour)
					{
						j = gamer.Perime6[0];
						gamer.Perime6.RemoveAt(0);
					}
					break;
				case 6:
					gamer.Perime7.Add(gamer.More7);
				  	if (gamer.Perime7.Count > tour)
					{
						j = gamer.Perime7[0];
						gamer.Perime7.RemoveAt(0);
					}
					break;
				case 7:
					gamer.Perime8.Add(gamer.More8);
				  	if (gamer.Perime8.Count > tour)
					{
						j = gamer.Perime8[0];
						gamer.Perime8.RemoveAt(0);
					}
					break;
				case 8:
					gamer.Perime9.Add(gamer.More9);
				  	if (gamer.Perime9.Count > tour)
					{
						j = gamer.Perime9[0];
						gamer.Perime9.RemoveAt(0);
					}
					break;
				case 9:
					gamer.Perime10.Add(gamer.More10);
				  	if (gamer.Perime10.Count > tour)
					{
						j = gamer.Perime10[0];
						gamer.Perime10.RemoveAt(0);
					}
					break;
				case 10:
					gamer.Perime11.Add(gamer.More11);
				  	if (gamer.Perime11.Count > tour)
					{
						j = gamer.Perime11[0];
						gamer.Perime11.RemoveAt(0);
					}
					break;
				case 11:
				  	gamer.Perime12.Add(gamer.More12);
				  	if (gamer.Perime12.Count > tour)
					{
						j = gamer.Perime12[0];
						gamer.Perime12.RemoveAt(0);
					}
					break;
			}
			gamer._marchandise[gamer._items[key]] = (Quantity-j, price, possible, promo, tour);
		
		}
	}

	public static void RemovePerime(PlayerClass gamer, int key)
	{
			switch (key)
			{
				case 0:
				  	if (gamer.Perime1.Count != 0 && gamer.Perime1[0] != 0)
						--gamer.Perime1[0];
					else if (gamer.Perime1.Count == 0)
						return;
					else
					{
						gamer.Perime1.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 1:
					if (gamer.Perime2.Count != 0 && gamer.Perime2[0] != 0)
						--gamer.Perime2[0];
					else if (gamer.Perime2.Count == 0)
						return;
					else
					{
						gamer.Perime2.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 2:
					if (gamer.Perime3.Count != 0 && gamer.Perime3[0] != 0)
						--gamer.Perime3[0];
					else if (gamer.Perime3.Count == 0)
						return;
					else
					{
						gamer.Perime3.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 3:
					if (gamer.Perime4.Count != 0 && gamer.Perime4[0] != 0)
						--gamer.Perime4[0];
					else if (gamer.Perime4.Count == 0)
						return;
					else
					{
						gamer.Perime4.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 4:
					if (gamer.Perime5.Count != 0 && gamer.Perime5[0] != 0)
						--gamer.Perime5[0];
					else if (gamer.Perime5.Count == 0)
						return;
					else
					{
						gamer.Perime5.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 5:
					if (gamer.Perime6.Count != 0 && gamer.Perime6[0] != 0)
						--gamer.Perime6[0];
					else if (gamer.Perime6.Count == 0)
						return;
					else
					{
						gamer.Perime6.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 6:
					if (gamer.Perime7.Count != 0 && gamer.Perime7[0] != 0)
						--gamer.Perime7[0];
					else if (gamer.Perime7.Count == 0)
						return;
					else
					{
						gamer.Perime7.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 7:
					if (gamer.Perime8.Count != 0 && gamer.Perime8[0] != 0)
						--gamer.Perime8[0];
					else if (gamer.Perime8.Count == 0)
						return;
					else
					{
						gamer.Perime8.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 8:
					if (gamer.Perime9.Count != 0 && gamer.Perime9[0] != 0)
						--gamer.Perime9[0];
					else if (gamer.Perime9.Count == 0)
						return;
					else
					{
						gamer.Perime9.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 9:
					if (gamer.Perime10.Count != 0 && gamer.Perime10[0] != 0)
						--gamer.Perime10[0];
					else if (gamer.Perime10.Count == 0)
						return;
					else
					{
						gamer.Perime10.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 10:
					if (gamer.Perime11.Count != 0 && gamer.Perime11[0] != 0)
						--gamer.Perime11[0];
					else if (gamer.Perime11.Count == 0)
						return;
					else
					{
						gamer.Perime11.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
				case 11:
				  	if (gamer.Perime12.Count != 0 && gamer.Perime12[0] != 0)
						--gamer.Perime12[0];
					else if (gamer.Perime12.Count == 0)
						return;
					else
					{
						gamer.Perime12.RemoveAt(0);
						RemovePerime(gamer, key);
					}
				  	break;
			}
	}


    public static void CalCulus(PlayerClass gamer, string Button)
    {
        System.Random aleatoire = new System.Random();
        double attractive = gamer._stat["Attracivité"];
        double client = gamer._stat["Clientèle"];
        int nb_client = aleatoire.Next((int)Math.Round(client / 2, 0), (int)Math.Round(client * 2, 0));
        int key;
        double sum = 0;
        if (gamer._turn)
        {
            for (int i = 0; i < nb_client; ++i)
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
								sum += price*0.8 + 0.1*price*(quali-1);
							else
                    			sum += price + 0.1*price*(quali-1);
						}
					}
                }
            }
			if (TourCount.TurnValues % 4 == 0)
          	{
             (double benef, double attract, double chance) =
                evenement._event[evenement._eventComing[TourCount.TurnValues/4 - 1]];
             gamer._stat["Attracivité"] *= attract;
             sum *= benef;
          	}

			for (int i = 0; i < 12; ++i)
				Perime(gamer, i);
            gamer.AddMoney(sum);
			gamer._mounth += sum;
            gamer._turn = true;
			bool b = false;
			if (TourCount.TurnValues % 4 == 0)
			{
				b = (!gamer.AddMoney(-gamer._mounth/4) || !gamer.AddMoney(-gamer._stat["Employé"]*gamer._stat["Salaire"]));
				if (b)
				{
					SceneManager.LoadScene("GameOver");
				}
				else
					gamer._mounth = 0;
			}
			TourCount.AddTurn(Button);
			gamer.TimeLeft = 100;
			if (TourCount.TurnValues > TourCount.MaxTurn || b)
			{
				SceneManager.LoadScene("GameOver");
			}
			else
				SceneManager.LoadScene("ScenePrincipale");
        }
    }
}
