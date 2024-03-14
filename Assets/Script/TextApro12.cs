using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class TextApro12 : NetworkBehaviour 
{
    public TextMeshProUGUI Apro12;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro12 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
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
        Apro12.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}