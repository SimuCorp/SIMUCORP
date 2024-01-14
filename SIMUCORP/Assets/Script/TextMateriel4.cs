using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMateriel4 : MonoBehaviour
{
    public TextMeshProUGUI Text4;
    
    // Start is called before the first frame update
    void Start()
    {
        Text4 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string res = Gamer1.materiel[3];
        Text4.text = res;
    }
}
