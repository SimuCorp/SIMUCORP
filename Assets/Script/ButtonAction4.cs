using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static Action4;
using static CountdownScript;
using static PlayerScript;

public class ButtonAction4 : MonoBehaviour
{
    // Start is called before the first frame update
	[SerializeField]
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => Action4.DoButtonAction4(temp, Gamer1));
    }

}
