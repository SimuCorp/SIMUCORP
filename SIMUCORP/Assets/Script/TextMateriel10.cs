using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMateriel10 : MonoBehaviour
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
        string res = Gamer1._missingitems[5];
		if (res == "done")
        	Text10.text = res;
		else
			Text10.text = $"{res}\n\n {300}";
    }
}
