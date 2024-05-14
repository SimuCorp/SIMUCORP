using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;
public class TextQuali : MonoBehaviour
{
    public TextMeshProUGUI Quali;
    public int n;
    
    // Start is called before the first frame update
    void Start()
    {
        Quali = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        PlayerClass g;
  
            g = PlayerScript.Gamer1;
     
        foreach (string s in g._marchandise.Keys)
        {
            if (i == n)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = g._marchandise[res];
        Quali.text = $"{res}\n\n{st} | {50*Math.Pow(st, 2)}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}
