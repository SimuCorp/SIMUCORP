using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextQuali8 : MonoBehaviour
{
    public TextMeshProUGUI Quali8;
    
    // Start is called before the first frame update
    void Start()
    {
        Quali8 = Quali8.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
		PlayerClass g = Gamer1;
        foreach (string s in g._marchandise.Keys)
        {
            if (i == 8)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = g._marchandise[res];
        Quali8.text = $"{res}\n\n{st} | {50*Math.Pow(st, 2)}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}
