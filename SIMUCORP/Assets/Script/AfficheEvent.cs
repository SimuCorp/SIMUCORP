using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static CountdownScript;
using UnityEngine.SceneManagement;
public class AfficheEvent : MonoBehaviour
{
    private static bool rentre;

    Text texte;
    // Start is called before the first frame update
    void Start()
    {
        rentre = true;
        texte = GetComponent<Text>();
        texte.text = "";
    }

    IEnumerator attend()
    {
        yield return new WaitForSeconds(50);
        texte.text = "";
    }

    // Update is called once per frame
    public void Affiche()
    {
        if (TourCount.TurnValues % 4 == 1 && TourCount.TurnValues != 1)
        {
            if (rentre)
            {
                texte.text = MoneyCount.evenement._eventComing[TourCount.TurnValues/4-1];
                rentre = true; 
                //StartCoroutine("attend");
            }
            
        }
        else
        {
            texte.text = "";
            rentre = true;
        }
    }

    void Update()
    {
        Affiche();
    }
}

