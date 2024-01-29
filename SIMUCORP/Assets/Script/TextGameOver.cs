using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using UnityEngine.SceneManagement;
using System.Threading;
public class TextGameOver : MonoBehaviour
{
    public Text GameOver;
    void Start()
    {
        GameOver = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamer1._money < Gamer2._money)
            GameOver.text = "Joueur2 a gagné";
        else 
        {
            if (Gamer1._money == Gamer2._money)
                GameOver.text = "Egalité";
            else
                GameOver.text = "Joueur1 a gagné";
        }
    }

}
