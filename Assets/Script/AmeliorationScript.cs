using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static PlayerScript;

public class AmeliorationScript : MonoBehaviour
{

    public int n;

    private void OnTriggerEnter(Collider other)
    {
          TextActionJoueur1.action.text = Gamer1.materiel[n] + " : 2500 $";
    }
}
