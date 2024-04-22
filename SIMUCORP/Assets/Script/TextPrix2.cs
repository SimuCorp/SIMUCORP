using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;

public class TextPrix2 : NetworkBehaviour 
{
    public TextMeshProUGUI Prix2;
    public static int n = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix2 = GetComponent<TextMeshProUGUI>();
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
            if (i == n)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = g._marchandise[res];
        Prix2.text = $"{res}\n\n{j}";
    }
}
