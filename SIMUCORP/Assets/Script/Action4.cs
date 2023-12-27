using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action4 : MonoBehaviour
{
    public Text TextAction4;
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
}
