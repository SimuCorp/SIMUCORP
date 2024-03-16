using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;

public class TextSalaire  : MonoBehaviour
{
    public TextMeshProUGUI Text1;

    public static double n = 1399;
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = $"Salaire\n\n{Gamer1._stat["Salaire"]} | {n}";
    }
}
