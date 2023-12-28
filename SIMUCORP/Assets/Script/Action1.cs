using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static CountdownScript;

public class Action1 : MonoBehaviour
{
    static Text TextAction1;

    private static string over;
    // Start is called before the first frame update
    void Start()
    {
        TextAction1 = GetComponent<Text> ();
        over = "";
    }

    // Update is called once per frame
    void Update()
    {

        TextAction1.text = $"{over}";
    }
    
    public static void ChangeAction1(string str, PlayerClass gamer)
    {
        if (str == "RH")
            over = gamer._rh[0];
        else if (str == "Commercial")
            over = gamer._commercial[0];
        else if (str == "Gestion")
            over = gamer._gestion[0];
        else
            over = "";
    }

    public static void DoButtonAction1(string str, PlayerClass gamer)
    {
        if (gamer._button)
        {
			System.Random aleatoire = new System.Random();
			int key = aleatoire.Next(0, gamer._items.Count);
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
            switch (TextAction1.text)
            {
                case "Promotion":
                    gamer._marchandise[gamer._items[key]] = (Quantity, price, possible, promo-0.3, 3);
					break;
                case "Employé":
                    ++gamer._stat["Employé"];
					break;
                case "Prix":
					gamer._marchandise[gamer._items[key]] = (Quantity, ++price, possible, promo, tour);
                    break;
                default:
                    break; 
            }

            CountdownScript.UpdateTimeButton(gamer);
        }
    }
}
