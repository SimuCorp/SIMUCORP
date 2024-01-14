using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
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
        string res = Gamer1._missingitems[2];
		if (res == "done")
        	Text7.text = res;
		else
			Text7.text = $"{res}\n\n {300}";
    }
}
