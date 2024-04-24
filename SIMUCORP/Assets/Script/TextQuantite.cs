using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TextQuantite : MonoBehaviour
{

    public int n;
    public Text Quantite;
    // Start is called before the first frame update
    void Start()
    {
        Quantite = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        string res = "";
        int i = 0;
        double x = Quantite.transform.position.x;
        double x2 = Screen.width/2;
        if (x <= x2)
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
        Quantite.text = $"{j}";
        g._marchandise[res] = (j, d, b, st, l);
    }
}
