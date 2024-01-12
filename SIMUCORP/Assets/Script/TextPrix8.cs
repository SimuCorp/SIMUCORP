using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextPrix8 : MonoBehaviour
{
    public TextMeshProUGUI Prix8;
    
    // Start is called before the first frame update
    void Start()
    {
        Prix8 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i == 8)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = Gamer1._marchandise[res];
        Prix8.text = $"{res}\n\n{j}";
    }
}
