using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;
public class TextMateriel1 : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
   
            g = Gamer1;

        string res = g.materiel[0];
        Text1.text = $"{res}\n\n {200}";
    }
}
