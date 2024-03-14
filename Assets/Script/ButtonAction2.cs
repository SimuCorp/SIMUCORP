using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static Action2;
using static CountdownScript;

public class ButtonAction2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    void Start()
    {
        string temp = gameObject.name;
    	gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonAction2(temp, Gamer1));
    }

}
