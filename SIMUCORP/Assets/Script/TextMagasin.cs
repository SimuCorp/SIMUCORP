using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMagasin : MonoBehaviour
{

	public TextMeshProUGUI Text1;

    public static double n = Gamer1._stat["Magasin"];
    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = $"Magasin\n\n{Gamer1._stat["Magasin"]} | {n}";
    }
}
