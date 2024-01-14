using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
public class TextMateriel9 : MonoBehaviour
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
        string res = Gamer1._missingitems[4];
		if (res == "done")
        	Text9.text = res;
		else
			Text9.text = $"{res}\n\n {300}";
    }
}
