using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
public class TextMateriel2 : NetworkBehaviour 
{
    public TextMeshProUGUI Text2;
    
    // Start is called before the first frame update
    void Start()
    {
        Text2 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g.materiel[1];
        Text2.text = $"{res}\n\n {2500}";
    }
}
