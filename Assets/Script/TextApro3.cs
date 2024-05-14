using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;

public class TextApro3 : MonoBehaviour
{
    public TextMeshProUGUI Apro3;
    public static int n = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro3 = GetComponent<TextMeshProUGUI>();
        n = 3;
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
        Apro3.text = $"{res}\n\n{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}