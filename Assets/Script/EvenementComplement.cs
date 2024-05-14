using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static CountdownScript;
using static PlayerScript;
using UnityEngine.SceneManagement;
public class EvenementComplement : MonoBehaviour
{
    public Image basic;
    public Sprite argent;
    public Sprite blackfriday;
    public Sprite travaux;
    public Sprite vacances;
    public Sprite courants;
    public Sprite emeute;
    public Sprite exposition;
    public Sprite inondation;
    public Sprite concert;
    public Sprite conference;
    public Sprite cambriolage;
    public Sprite braderie;
    public Sprite inflation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool verif = TourCount.TurnValues%4 == 1 && TourCount.TurnValues != 1;
        if (verif)
        {
            string event1 = PlayerScript.evenement._eventComing[TourCount.TurnValues/4-1];
        
            if (event1 == "Entrée d'argent")
                basic.sprite = argent;
            else if (event1 == "Black Friday")
                basic.sprite = blackfriday;
            else if (event1 == "Travaux")
                basic.sprite = travaux;
            else if (event1 == "Vacances")
                basic.sprite = vacances;
            else if (event1 == "Inflation")
                basic.sprite = inflation;
            else if (event1 == "Coupure de courant")
                basic.sprite = courants;
            else if (event1 == "Emeute")
                basic.sprite = emeute;
            else if (event1 == "Exposition")
                basic.sprite = exposition;
            else if (event1 == "Inondation")
                basic.sprite = inondation;
            else if (event1 == "Concert")
                basic.sprite = concert;
            else if (event1 == "Conférence")
                basic.sprite = conference;
            else if (event1 == "Cambriolage")
                basic.sprite = cambriolage;
            else
                basic.sprite = braderie;
        }
           
    }
}
