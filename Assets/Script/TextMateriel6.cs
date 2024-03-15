using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMateriel6 : MonoBehaviour 
{
    public TextMeshProUGUI Text6;
    
    // Start is called before the first frame update
    void Start()
    {
        Text6 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g = Gamer1;
        string res = g._missingitems[1];
		if (res == "done")
        	Text6.text = res;
		else
			Text6.text = $"{res}\n\n {300}";
    }
}
