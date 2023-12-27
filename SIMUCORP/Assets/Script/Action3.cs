using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action3 : MonoBehaviour
{
    Text TextAction3;
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
}
