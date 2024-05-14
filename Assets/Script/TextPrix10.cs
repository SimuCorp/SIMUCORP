using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class TextPrix10 : MonoBehaviour
{
    public TextMeshProUGUI Prix10;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix10 = GetComponent<TextMeshProUGUI>();
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
            if (i == 10)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = g._marchandise[res];
        Prix10.text = $"{res}\n\n{j}";
    }
}
