using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static Action1;
using static CountdownScript;

public class ButtonAction1 : MonoBehaviour
{
    
    // Start is called before the first frame update
	[SerializeField]
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => Action1.DoButtonAction1(temp, Gamer1));
    }
    
}
