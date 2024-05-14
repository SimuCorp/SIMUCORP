using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class TextPrix4 : MonoBehaviour
{
    public TextMeshProUGUI Prix4;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix4 = GetComponent<TextMeshProUGUI>();
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
            if (i == 4)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = g._marchandise[res];
        Prix4.text = $"{res}\n\n{j}";
    }
}
