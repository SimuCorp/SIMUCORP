using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;
public class TextMateriel8 : MonoBehaviour
{
    public TextMeshProUGUI Text8;
    
    // Start is called before the first frame update
    void Start()
    {
        Text8 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
       
            g = Gamer1;

        string res = g._missingitems[3];
		if (res == "done")
        	Text8.text = res;
		else
			Text8.text = $"{res}\n\n {300}";
    }
}
