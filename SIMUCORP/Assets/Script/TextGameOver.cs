using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using UnityEngine.SceneManagement;
using System.Threading;
using static PlayerScript;

public class TextGameOver : MonoBehaviour
{
    public TextMeshProUGUI GameOver;
    void Start()
    {
        GameOver = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamer1._money < Gamer2._money)
            GameOver.text = "Joueur2 a gagné\nRetour à l'écran d'accueil";
        else 
        {
            if (Gamer1._money == Gamer2._money)
                GameOver.text = "Egalité\nRetour à l'écran d'accueil";
            else
                GameOver.text = "Joueur1 a gagné\nRetour à l'écran d'accueil";
        }
    }

}
