using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;

public class TextApro : MonoBehaviour
{
    public int n;
    public TextMeshProUGUI Apro;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro = GetComponent<TextMeshProUGUI>();
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
        Apro.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}

