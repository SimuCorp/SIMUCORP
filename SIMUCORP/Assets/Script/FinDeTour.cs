using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static System.Math;
using static MoneyCount;
using static TourCount;
using static PlayerClass;
using static Player1Script;
using static PlayerScript;

public class FinDeTour : MonoBehaviour
{

    public Text Information;
    // Start is called before the first frame update
    void Start()
    {
        Information = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Information.text = $"Fin de la semaine {TourCount.TurnValues-1}\nTotal des Ventes du Joueur 1 : {Round(TextActionJoueur1.Vente1, 2)} $\n Total des Ventes du Joueur 2 : {Round(TextActionJoueur1.Vente2, 2)} $";
    }
}
