using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;
public class TextMateriel7 : MonoBehaviour
{
    public TextMeshProUGUI Text7;
    
    // Start is called before the first frame update
    void Start()
    {
        Text7 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
 
            g = Gamer1;
  
        string res = g._missingitems[2];
		if (res == "done")
        	Text7.text = res;
		else
			Text7.text = $"{res}\n\n {300}";
    }
}
