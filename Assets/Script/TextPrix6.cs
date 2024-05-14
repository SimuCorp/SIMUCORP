using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class TextPrix6 : MonoBehaviour
{
    public TextMeshProUGUI Prix6;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix6 = GetComponent<TextMeshProUGUI>();
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
            if (i == 6)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = g._marchandise[res];
        Prix6.text = $"{res}\n\n{j}";
    }
}       
