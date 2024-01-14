using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextQuali1 : MonoBehaviour
{
    public TextMeshProUGUI Quali1;
    
    // Start is called before the first frame update
    void Start()
    {
        Quali1 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i == 1)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = Gamer1._marchandise[res];
        Quali1.text = $"{res}\n\n{st} | {50*Math.Pow(st, 2)}";
        Gamer1._marchandise[res] = (j, d, b, st, l);
    }
}
