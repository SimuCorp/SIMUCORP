using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class TextEmploye : MonoBehaviour 
{
    public TextMeshProUGUI Text1;
    
    public static double n = 0;

    private PlayerClass g;
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        n = g._stat["Employé"];
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = $"Employé\n\n{g._stat["Employé"]} | {n}";
    }
}
