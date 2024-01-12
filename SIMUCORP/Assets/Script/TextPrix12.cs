using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextPrix12 : MonoBehaviour
{
    public TextMeshProUGUI Prix12;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix12 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i == 12)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = Gamer1._marchandise[res];
        Prix12.text = $"{res}\n\n{j}";
    }
}