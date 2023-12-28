using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class ButtonPass : MonoBehaviour
{
    public void DoButtonPass(string str, PlayerClass gamer)
    {
        Action1.ChangeAction1(str, gamer);
        Action2.ChangeAction2(str, gamer);
        Action3.ChangeAction3(str, gamer);
        Action4.ChangeAction4(str, gamer);
        CalCulus(gamer, str);
		CountdownScript.UpdateTimeButton(gamer);
    }
	[SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonPass(temp, Gamer1));
    }
    
}
