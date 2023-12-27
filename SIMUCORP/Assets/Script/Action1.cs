using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Action1 : MonoBehaviour
{
    Text TextAction1;

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
}
