using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action4 : MonoBehaviour
{
    public static Text TextAction4;
	private static string over;
    // Start is called before the first frame update
    void Start()
    {
        TextAction4 = GetComponent<Text> ();
		over = "";
    }

    // Update is called once per frame
    void Update()
    {
        TextAction4.text = $"{over}";
    }

    public static void ChangeAction4(string str, PlayerClass gamer)
    {
        if (str == "RH")
            over = gamer._rh[3];
        else if (str == "Commercial")
            over = gamer._commercial[3];
        else if (str == "Gestion")
            over = gamer._gestion[3];
        else
            over = "";
    }
    
    public static void DoButtonAction4(string str, PlayerClass gamer)
    {
        if (gamer._button)
        {
            System.Random aleatoire = new System.Random();
            int key = aleatoire.Next(0, gamer._items.Count);
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
            switch (TextAction4.text)
            {
                case "Cadeau":
                    gamer._stat["Attractivité"] += 10;
                    break;
                case "Prime":
                    gamer.AddMoney(-1000);;
                    break;
                case "Matériels":
                    gamer._stat["Attractivité"] += 10;
                    gamer.AddMoney(-1000);
                    break;
                default:
                    break;
            }

            CountdownScript.UpdateTimeButton(gamer);
        }
    }
}
