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
    public bool joueur1;
    // Start is called before the first frame update
    void Start()
    {
        Information = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string vente;
        string diff;
        PlayerClass gamer;
        int Quantity;
        if (joueur1)
        {
            gamer = Gamer1;
            vente = (Round(TextActionJoueur1.Vente1, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
            diff = (Round(TextActionJoueur1.diff1, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
            Quantity = TextActionJoueur1.Quantity1;
        }
        else
        {
            gamer = Gamer2;
            vente = (Round(TextActionJoueur1.Vente2, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
            diff = (Round(TextActionJoueur1.diff2, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
            Quantity = TextActionJoueur1.Quantity2;
        }
        string money = (Round(gamer.last_money, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
        string attrat = (Round(gamer.last_attrat, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
        Information.text = $"Statistiques de la semaine {TourCount.TurnValues-1} du {gamer._name}\n Total des ventes : {vente} $\n Total des marchandises vendues : {Quantity}\n Bénéfices de la semaine : {diff} $\n Argent restant : {money} $";
        Information.text += $"\n\n Statistiques générales\n Nombre d'employés : {gamer._stat["Employé"]}\n Nombre de magasin : {gamer._stat["Magasin"]}\n Attractivité de la franchise : {attrat}";
        Information.text += $"\nQualité générales de la franchise : {gamer._stat["Qualité"]}";

    }
}
