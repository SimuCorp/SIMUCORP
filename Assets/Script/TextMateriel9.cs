using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;
public class TextMateriel9 : NetworkBehaviour 
{
    public TextMeshProUGUI Text9;
    
    // Start is called before the first frame update
    void Start()
    {
        Text9 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g._missingitems[4];
		if (res == "done")
        	Text9.text = res;
		else
			Text9.text = $"{res}\n\n {300}";
    }
}
