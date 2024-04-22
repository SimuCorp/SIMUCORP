using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class TextApro2 : NetworkBehaviour 
{
    public TextMeshProUGUI Apro2;
    public static int n = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro2 = GetComponent<TextMeshProUGUI>();
        n = 2;
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        PlayerClass g;
        if (this.isServer)
            g = PlayerScript.Gamer1;
        else
            g = PlayerScript.Gamer2;
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
        Apro2.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}
