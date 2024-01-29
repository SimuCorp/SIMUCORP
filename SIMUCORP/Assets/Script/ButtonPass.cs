using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class ButtonPass : MonoBehaviour
{
    public void DoButtonPass(string str, PlayerClass gamer)
    {
        gamer._button = false;
        if (Gamer1._button == Gamer2._button)
        {
            CalCulus(gamer, str);
            CalCulus(Gamer2, str);
            CountdownScript.UpdateTimeButton(gamer);
        }
    }
	[SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonPass(temp, Gamer1));
    }
    
}
