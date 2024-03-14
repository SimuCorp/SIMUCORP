using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class TextPromo : NetworkBehaviour 
{
    public TextMeshProUGUI TextPro;
    void Start()
    {
        TextPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        if (g.promo)
            TextPro.text = "Promotion\n\nEn cours";
        else
            TextPro.text = "Promotion\n\nEn attente";

    }
}
