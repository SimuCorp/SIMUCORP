using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;
public class TextMateriel7 : NetworkBehaviour 
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
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g._missingitems[2];
		if (res == "done")
        	Text7.text = res;
		else
			Text7.text = $"{res}\n\n {300}";
    }
}
