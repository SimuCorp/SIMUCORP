using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextApro7 : MonoBehaviour
{
    public TextMeshProUGUI Apro7;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro7 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i == 7)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = Gamer1._marchandise[res];
        Apro7.text = $"{res}\n\n{j}";
        Gamer1._marchandise[res] = (j, d, b, st, l);
    }
}