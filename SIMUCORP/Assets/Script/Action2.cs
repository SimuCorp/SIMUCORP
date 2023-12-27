using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action2 : MonoBehaviour
{
    Text TextAction2;
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
}
