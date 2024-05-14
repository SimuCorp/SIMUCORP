using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static IntelligenceArtificielle;
using static PlayerScript;

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
        if (true)
		{	
			DoAction();
		}
        MoneyInfo.text = (Math.Round(Gamer2._money, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US")) + " $";
         if (Gamer2._money >= 5000)
            MoneyInfo.color = Color.green;
        else if (Gamer2._money >= 1000)
            MoneyInfo.color = Color.yellow;
        else
            MoneyInfo.color = Color.red;
    }
}
