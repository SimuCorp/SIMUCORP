using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyCount : MonoBehaviour
{
    public static Primeur Gamer1 = new Primeur("Primeur");
    Text MoneyInformation;
    // Start is called before the first frame update
    void Start()
    {
        MoneyInformation = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyInformation.text = $"Money : {Gamer1._money}";
    }

    public static void CalCulus(PlayerClass gamer, string Button)
    {
        System.Random aleatoire = new System.Random();
        int attractive = gamer._stat["Attracivité"];
        int client = gamer._stat["Clientèle"];
        int nb_client = aleatoire.Next(client / 2, client * 2);
        int key;
        double sum = 0;
        if (gamer._turn)
        {
            for (int i = 0; i < nb_client; ++i)
            {

                if (aleatoire.Next(0, 101) < attractive)
                {
                    key = aleatoire.Next(0, gamer._items.Count);
                    (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
                    gamer._marchandise[gamer._items[key]] = (--Quantity, price, possible, promo, tour);
                    sum += price;
                }
            }
			for (int i = 0; i < gamer._items.Count; ++i)
			{
				(int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[i]];
				tour -= 1;
				if (tour <= 0)
					gamer._marchandise[gamer._items[i]] = (Quantity, price, possible, 1, 0);
			}

            gamer.AddMoney(sum);
			gamer._mounth += sum;
            TourCount.AddTurn(Button);
            gamer._turn = false;
			if (TourCount.TurnValues % 4 == 1)
				gamer.AddMoney(-Math.Round((gamer._mounth/4), 2));
        }
    }
}
