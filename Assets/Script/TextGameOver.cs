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
            GameOver.text = $"Le {Gamer2._name} a gagné";
        else 
        {
            if (Gamer1._money == Gamer2._money)
                GameOver.text = $"Egalité parfaite entre le {Gamer1._name} et le {Gamer2._name}";
            else
                GameOver.text = $"Le {Gamer1._name} a gagné";
        }
    }

}
