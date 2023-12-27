using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
public class ButtonCommercial : MonoBehaviour
{

	public void DoButtonCommercial(string str, PlayerClass gamer)
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
        gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonCommercial("Commercial", Gamer1));
    }
    
}
