using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class TextApro9 : MonoBehaviour 
{
    public TextMeshProUGUI Apro9;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro9 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        PlayerClass g;

            g = Gamer1;

        foreach (string s in g._marchandise.Keys)
        {
            if (i == 9)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = g._marchandise[res];
        Apro9.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}