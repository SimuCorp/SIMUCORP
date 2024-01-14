using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMateriel5 : MonoBehaviour
{
    public TextMeshProUGUI Text5;
    
    // Start is called before the first frame update
    void Start()
    {
        Text5 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string res = Gamer1._missingitems[0];
		if (res == "done")
        	Text5.text = res;
		else
			Text5.text = $"{res}\n\n {300}";
    }
}
