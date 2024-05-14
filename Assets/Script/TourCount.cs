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
        NB_tour.text = $"Semaine {TurnValues}/{MaxTurn}";
        /*
        if (TurnValues <= MaxTurn/3)
            NB_tour.color = Color.green;
        else if (TurnValues <= 2*MaxTurn/3)
            NB_tour.color = Color.yellow;
        else
            NB_tour.color = Color.red;
            */
            
    }

	public static void AddTurn(string Button)
	{
		++TurnValues;
	}
}
