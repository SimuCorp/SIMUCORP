using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;
public class TextSalaire : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    private PlayerClass g;

    public static double n = 1199;
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
    
            g = Gamer1;
   
        n = g._stat["Salaire"];
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = $"Salaire\n\n{g._stat["Salaire"]} | {n}";
    }
}
