using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextApro10 : MonoBehaviour
{
    public TextMeshProUGUI Apro10;
    
    // Start is called before the first frame update
    void Start()
    {
        Apro10 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i == 10)
            {
                res = s;
                break;
            }

            ++i;
        }

        (int j, double d, bool b, double st, int l) = Gamer1._marchandise[res];
        Apro10.text = $"{res}\n\n{j}";
        Gamer1._marchandise[res] = (j, d, b, st, l);
    }
}