using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static Action1;
using static Action2;
using static Action3;
using static Action4;
public class ButtonRH : MonoBehaviour
{

	public void DoButtonRh(string str, PlayerClass gamer)
	{
		Action1.ChangeAction1(str, gamer);
		Action2.ChangeAction2(str, gamer);
		Action3.ChangeAction3(str, gamer);
		Action4.ChangeAction4(str, gamer);
	}
    // Start is called before the first frame update
    [SerializeField]
    void Start()
    {
        string temp = gameObject.name;
	
    }
	void Update()
	{
		gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonRh("RH", Gamer1));
	}
    
}
