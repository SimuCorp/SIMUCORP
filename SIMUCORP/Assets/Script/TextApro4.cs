using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;

public class TextApro4 : MonoBehaviour
{
    public TextMeshProUGUI Apro4;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro4 = GetComponent<TextMeshProUGUI>();
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
            if (i == 4)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = g._marchandise[res];
        Apro4.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}