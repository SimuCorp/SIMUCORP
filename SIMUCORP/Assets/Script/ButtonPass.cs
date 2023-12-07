using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPass : MonoBehaviour
{

	[SerializeField]
	private bool physical;
    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => TourCount.AddTurn(temp));
    }

    // Update is called once per frame
    void Update()
    {
		string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => TourCount.AddTurn(temp));
    }
}
