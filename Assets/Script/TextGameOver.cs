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
        (double score1, int amelioration1) = Score(true);
        (double score2, int amelioration2) = Score(false);
        /*
        GameOver.text = "Argent restant\n";
        GameOver.text += (Math.Round(Gamer1._money, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US")) + " $"+" | "+ (Math.Round(Gamer2._money, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US")) + " $"+'\n';
        GameOver.text += "Argent gagné\n";
        string totvent1 = (Round(TextActionJoueur1.TotalVente1, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
        string totvent2 = (Round(TextActionJoueur1.TotalVente2, 2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"));
        GameOver.text += $"{totvent1} $ | {totvent2} $\n";
        GameOver.text += "Quantite de marchandise vendu\n";
        GameOver.text += $"{Gamer1.quantite} | {Gamer2.quantite}\n";
        GameOver.text += "Nombre d'amelioration\n";
        GameOver.text += $"{amelioration1} | {amelioration2}\n";
        GameOver.text += "Score\n";
        GameOver.text += (Round(score1,2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"))+ " | " +(Round(score2,2)).ToString("G",
                  new System.Globalization.CultureInfo("en-US"))+"\n";
        */
        if (score1 < score2)
            GameOver.text = $"Le {Gamer2._name.ToLower()} a gagné";
        else if (score1 == score2)
            GameOver.text = $"Egalité parfaite entre le {Gamer1._name.ToLower()} et le {Gamer2._name.ToLower()}";
        else
            GameOver.text = $"Le {Gamer1._name.ToLower()} a gagné";
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
