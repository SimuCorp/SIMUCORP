using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextPromo : MonoBehaviour
{
    public TextMeshProUGUI TextPro;
    void Start()
    {
        TextPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g = Gamer1;
        if (g.promo)
            TextPro.text = "Promotion\n\nEn cours";
        else
            TextPro.text = "Promotion\n\nEn attente";

    }
}
