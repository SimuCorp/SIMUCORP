using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class TourCount : MonoBehaviour
{
    
    public static int TurnValues = 1;

    public static int MaxTurn = 13;
    // Start is called before the first frame update
    Text NB_tour;
    void Start()
    {
        NB_tour = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        NB_tour.text = $"Turn : {TurnValues}";
    }

	public static void AddTurn(string Button)
	{
		++TurnValues;
	}
}
