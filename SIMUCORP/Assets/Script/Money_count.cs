using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_count : MonoBehaviour
{

    public static int moneyValues = 0;

    Text money;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        money.text = $" : {moneyValues}";
    }
}
