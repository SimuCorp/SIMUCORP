using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMateriel3 : MonoBehaviour
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
        PlayerClass g = Gamer1;
        string res = g.materiel[2];
        Text3.text = $"{res}\n\n {2500}";
    }
}
