using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class TextSalaire : NetworkBehaviour 
{
    public TextMeshProUGUI Text1;
    private PlayerClass g;

    public static double n = 1199;
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        n = g._stat["Salaire"];
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = $"Salaire\n\n{g._stat["Salaire"]} | {n}";
    }
}
