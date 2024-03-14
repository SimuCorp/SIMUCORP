using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static IntelligenceArtificielle;

public class MoneyJoueur2 : MonoBehaviour
{
    Text MoneyInfo;

   // Start is called before the first frame update
    void Start()
    {
        MoneyInfo = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (!(multijoueur))
		{	
			DoAction();
		}
		(int Quantity, double price, bool possible, double promo, int tour) = Gamer2._marchandise["Steak Haché"];
        MoneyInfo.text = $"{Math.Round(Gamer2._money, 2)}$";
    }
}
