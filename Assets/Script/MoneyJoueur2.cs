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
        MoneyInfo.text = $"{Math.Round(Gamer2._money, 2)}$";
    }
}
