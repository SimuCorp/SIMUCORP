using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class TextMagasin : MonoBehaviour
{

	public TextMeshProUGUI Text1;

    public static double n = 1;
    private PlayerClass g;
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
     
            g = Gamer1;
  
        n = g._stat["Magasin"];
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = $"Magasin\n\n{g._stat["Magasin"]} | {n}";
    }
}
