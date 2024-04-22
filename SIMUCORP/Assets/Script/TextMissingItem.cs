using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;
public class TextMissingItem : NetworkBehaviour 
{
    public TextMeshProUGUI Text;
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g._missingitems[n];
		if (res == "done")
        	Text.text = res;
		else
			Text.text = $"{res}\n\n {300}";
    }
}
