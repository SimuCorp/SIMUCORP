using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;
public class TextMateriel8 : NetworkBehaviour 
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
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g._missingitems[3];
		if (res == "done")
        	Text8.text = res;
		else
			Text8.text = $"{res}\n\n {300}";
    }
}
