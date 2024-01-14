using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
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
        string res = Gamer1.materiel[0];
        Text1.text = $"{res}\n\n {200}";
    }
}
