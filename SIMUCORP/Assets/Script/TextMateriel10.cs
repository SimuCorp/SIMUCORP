using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
public class TextMateriel10 : NetworkBehaviour 
{
    public TextMeshProUGUI Text10;
    
    // Start is called before the first frame update
    void Start()
    {
        Text10 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass g;
        if (this.isServer)
            g = Gamer1;
        else
            g = Gamer2;
        string res = g._missingitems[5];
		if (res == "done")
        	Text10.text = res;
		else
			Text10.text = $"{res}\n\n {300}";
    }
}
