using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextPrix3 : MonoBehaviour
{
    public TextMeshProUGUI Prix3;
    
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
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i == 3)
            {
                res = s;
                break;
            }

            ++i;
        }

        (_, double j, _, _, _) = Gamer1._marchandise[res];
        Prix3.text = $"{res}\n\n{j}";
    }
}