using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class TextPrix3 : MonoBehaviour
{
    public TextMeshProUGUI Prix3;
    public static int n = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix3 = GetComponent<TextMeshProUGUI>();
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
            if (i == n)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = g._marchandise[res];
        Prix3.text = $"{res}\n\n{j}";
    }
}