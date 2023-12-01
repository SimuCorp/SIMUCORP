using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tour_count : MonoBehaviour
{
    
    public static int TurnValues = 1;
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
}
