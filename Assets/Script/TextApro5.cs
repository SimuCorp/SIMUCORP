using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;

public class TextApro5 : MonoBehaviour 
{
    public TextMeshProUGUI Apro5;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro5 = GetComponent<TextMeshProUGUI>();
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
            if (i == 5)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = g._marchandise[res];
        Apro5.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}