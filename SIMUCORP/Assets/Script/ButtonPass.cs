using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class ButtonPass : MonoBehaviour
{

	[SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => CalCulus(Gamer1, temp));
    }

    // Update is called once per frame
    void Update()
    {
		string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => CalCulus(Gamer1, temp));
    }
}