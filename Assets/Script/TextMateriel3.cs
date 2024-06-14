using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;
public class TextMateriel3 : NetworkBehaviour 
{
    public TextMeshProUGUI Text3;
    
    // Start is called before the first frame update
    void Start()
    {
        Text3 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g.materiel[2];
        Text3.text = $"{res}\n\n {2500}";
    }
}
