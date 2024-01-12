using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action3 : MonoBehaviour
{
    static Text TextAction3;
	private static string over;
    // Start is called before the first frame update
    void Start()
    {
        TextAction3 = GetComponent<Text> ();
		over = "";
    }

    // Update is called once per frame
    void Update()
    {
        TextAction3.text = $"{over}";
    }
    
    public static void ChangeAction3(string str, PlayerClass gamer)
    {
        if (str == "RH")
            over = gamer._rh[2];
        else if (str == "Commercial")
            over = gamer._commercial[2];
        else if (str == "Gestion")
            over = gamer._gestion[2];
        else
            over = "";
    }

    public static void DoButtonAction3(string str, PlayerClass gamer)
    {
        if (gamer._button)
        {
            System.Random aleatoire = new System.Random();
            int key = aleatoire.Next(0, gamer._items.Count);
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
            switch (TextAction3.text)
            {
                case "Carte de fidélité":
                    gamer._stat["Attracivité"] += 10;
                    break;
                case "Magasin":
                    gamer._stat["Magasin"] += 1;
                    break;
                case "Qualité":
                    gamer._stat["Attracivité"] += 10;
                    gamer.AddMoney(-1000);
                    break;
                default:
                    break;
            }

            CountdownScript.UpdateTimeButton(gamer);
        }
    }
}
