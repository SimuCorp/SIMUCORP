using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerScript;
using static TextActionJoueur1;
public class Faillite : MonoBehaviour
{
    Text faillite;
    void Start()
    {
        faillite = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TextActionJoueur1.faill1)
        {
            if(TextActionJoueur1.faill2)
                faillite.text = $"Egalité parfaite entre le {Gamer1._name.ToLower()} et le {Gamer2._name.ToLower()}";
            else
                faillite.text = $"Le {Gamer2._name.ToLower()} a gagné";
        }
        else
        {
            faillite.text = $"Le {Gamer1._name.ToLower()} a gagné";
        }
    }
}
