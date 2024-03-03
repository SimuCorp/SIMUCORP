using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class ButtonPass : NetworkBehaviour
{
    public void DoButtonPass(string str, PlayerClass gamer)
    {
        gamer._button = false;
        if (Gamer1._button == Gamer2._button)
        {
            CalCulus(Gamer1, str);
            CalCulus(Gamer2, str);
            CountdownScript.UpdateTimeButton(gamer);
        }
    }
	[SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        PlayerClass gamer;
        if (isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonPass(temp, gamer));
    }
    
}
