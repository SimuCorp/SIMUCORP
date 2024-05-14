using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static CountdownScript;
using static PlayerScript;
using UnityEngine.SceneManagement;
public class AfficheEvent : MonoBehaviour
{
    private static bool rentre;
    public GameObject image;
    public GameObject image2;
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
        yield return new WaitForSeconds(10);
        texte.text = "";
    }

    // Update is called once per frame
    public void Affiche()
    {
        if (TourCount.TurnValues % 4 == 1 && TourCount.TurnValues != 1)
        {
            image.SetActive(true);
            image2.SetActive(true);
            if (rentre)
            {
                texte.text ="Evènement : " + evenement._eventComing[TourCount.TurnValues/4-1];
                (double benef, double attract, double chance) =
                evenement._event[evenement._eventComing[TourCount.TurnValues/4 - 1]];
                if (benef >= 1)
                    texte.color = Color.green;
                else
                    texte.color = Color.red;
                rentre = false; 
                StartCoroutine("attend");
               
            }
            
        }
        else
        {
            texte.text = "";
            rentre = true;
            image.SetActive(false);
            image2.SetActive(false);
        }
    }

    void Update()
    {
        Affiche();
    }
}

