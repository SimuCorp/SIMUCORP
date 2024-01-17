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

    public Text texte;
    // Start is called before the first frame update
    void Start()
    {
        rentre = true;
        texte = GetComponent<Text>();
        texte.text = "";
    }

    IEnumerator attend()
    {
        yield return new WaitForSeconds(4);
        texte.text = "";
    }

    // Update is called once per frame
    public void Affiche(Text texte)
    {
        if (TourCount.TurnValues % 4 == 1 && TourCount.TurnValues != 1)
        {
            if (rentre)
            {
                texte.text = evenement._eventComing[TourCount.TurnValues-1];
                rentre = false;
                StartCoroutine("attend");
            }
            
        }
        else
        {
            texte.text = "";
            rentre = true;
        }
    }

    private void Update()
    {
        Affiche(texte);
    }
}

