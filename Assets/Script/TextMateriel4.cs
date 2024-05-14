using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;
public class TextMateriel4 : MonoBehaviour
{
    public TextMeshProUGUI Text4;
    
    // Start is called before the first frame update
    void Start()
    {
        Text4 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
   
            g = Gamer1;

        string res = g.materiel[3];
        Text4.text = res;
    }
}
