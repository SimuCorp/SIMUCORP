using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using static PlayerScript;
public class TextQuali12 : MonoBehaviour
{
    public TextMeshProUGUI Quali12;
    
    // Start is called before the first frame update
    void Start()
    {
        Quali12 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
       
        PlayerClass g = Gamer1;
    
        foreach (string s in g._marchandise.Keys)
        {
            if (i == 12)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = g._marchandise[res];
        Quali12.text = $"{res}\n\n{st} | {50*Math.Pow(st, 2)}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}
