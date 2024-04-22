using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action2 : MonoBehaviour
{
    static Text TextAction2;
	private static string over;
    // Start is called before the first frame update
    void Start()
    {
        TextAction2 = GetComponent<Text> ();
		over = "";
    }

    // Update is called once per frame
    void Update()
    {
        TextAction2.text = $"{over}";
    }
    
    public static void ChangeAction2(string str, PlayerClass gamer)
    {
        if (str == "RH")
            over = gamer._rh[1];
        else if (str == "Commercial")
            over = gamer._commercial[1];
        else if (str == "Gestion")
            over = gamer._gestion[1];
        else
            over = "";
    }
    
    public static void DoButtonAction2(string str, PlayerClass gamer)
    {
        if (gamer._button)
        {
            System.Random aleatoire = new System.Random();
            int key = aleatoire.Next(0, gamer._items.Count);
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
            switch (TextAction2.text)
            {
                case "Publicité":
                    gamer._stat["Attractivité"] += 10;
                    break;
                case "Salaire":
                    gamer._stat["Salaire"] += 100;
                    break;
                case "Approvisionnement":
                    gamer._marchandise[gamer._items[key]] = (++Quantity, price, possible, promo, tour);
                    break;
                default:
                    break; 
            }
            CountdownScript.UpdateTimeButton(gamer);
        }
    }
}
