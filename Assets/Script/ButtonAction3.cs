using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static Action3;
using static CountdownScript;
using static PlayerScript;

public class ButtonAction3 : MonoBehaviour
{
    // Start is called before the first frame update
	[SerializeField]
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => Action3.DoButtonAction3(temp, Gamer1));
    }

}
