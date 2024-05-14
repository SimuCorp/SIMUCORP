using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using UnityEngine.SceneManagement;
using System.Threading;
using static System.Math;
using static PlayerScript;
using static TextActionJoueur1;

public class resultat_joueur : MonoBehaviour
{
    public TextMeshProUGUI GameOver;
    public bool joueur1;
    void Start()
    {
        GameOver = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClass gamer;
        if (joueur1)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        (double score1, int amelioration1) = Score(joueur1);

        GameOver.text = $"{gamer._name}\n\nArgent restant\n";
        GameOver.text += (Math.Round(gamer.last_money, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US")) + " $"+'\n';
        GameOver.text += "Argent gagné\n";
        string totvent;
        double emp;
        if (joueur1)
        {
            totvent = (Round(TextActionJoueur1.TotalVente1, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
            emp = TextActionJoueur1.NbSalaire1;
        }
        else
        {
            totvent = (Round(TextActionJoueur1.TotalVente2, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
            emp = TextActionJoueur1.NbSalaire2;
        }
        GameOver.text += $"{totvent} $\n";
        GameOver.text += "Quantité de marchandises vendues\n";
        GameOver.text += $"{gamer.quantite}\n";
        GameOver.text += "Nombre d'améliorations\n";
        GameOver.text += $"{amelioration1}\n";
        GameOver.text += "Nombre de salaire versés\n";
        GameOver.text += $"{emp}";
        string attrat = (Math.Round(gamer._stat["Attractivité"], 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
        GameOver.text += $"\nNombre de magasin\n{gamer._stat["Magasin"]}\nAttractivité de la franchise\n{attrat}\n";
        GameOver.text += "Score\n";
        GameOver.text += (Round(score1,2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
    }

    private (double, int) Score(bool verif)
    {
        PlayerClass gamer;
        if (verif)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        double res = 0;
        int quantite = 0;
        int level = 0;
        int prod = 0;
        foreach (string s in gamer._marchandise.Keys)
        {
            (int quant, double prix, bool produit, double lvl, int turn) = gamer._marchandise[s];
            quantite += quant;
            level += (int)lvl;
            if (produit)
                ++prod;
        }
        int amelioration = 0;
        foreach (string s in gamer.materiel)
        {
            if (s == "acheté")
                amelioration += 1000;
        }
        double emp;
        if (verif)
            emp = TextActionJoueur1.NbSalaire1;
        else
            emp = TextActionJoueur1.NbSalaire2;
        return (((prod+gamer._stat["Magasin"])/7*(1+emp)*gamer.last_money*(prod*100-quantite+100*level/12+gamer.quantite+amelioration*gamer._stat["Attractivité"])+gamer.quantite)/10000, amelioration/1000);
        
    }
}
