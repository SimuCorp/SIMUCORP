using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pret_a_porter : PlayerClass
{
   public Pret_a_porter(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Tee-shirt", (200, 5, true, 1, 500) },
            { "Short", (200, 7, true, 1, 500) },
            { "Sous-vetements", (200, 9, true, 1, 500) },
            { "Jogging", (200, 14, true, 1, 500) },
            { "Chapeau", (200, 20, true, 1, 500) },
            { "Gants", (200, 25, true, 1, 500) },
            { "Robe", (0, 30, false, 1, 0) },
            { "Jean", (0, 27.20, false, 1, 0) },
            { "Manteau", (0, 80, false, 1, 0) },
            { "Chaussures", (0, 77, false, 1, 0) },
            { "Veste en cuir", (0, 250, false, 1, 0) },
            { "Costume", (0, 500, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attracivité", 40 },
            { "Clientèle", 250 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Tee-shirt", "Short", "Sous-vetements", "Jogging", "Chapeau", "Gants"};
       for (int i = 0; i < 6; ++i)
          _items.Add("NaN");
        _missingitems = new List<string> { "Robe", "Jean", "Manteau", "Chaussures", "Veste en cuir", "Costume"};
        materiel = new List<string> { "tableau de promotion", "Cabine d'essayage", "Led décorative", "nouveaux vêtements" };
        prix = new List<double> {3.33, 4.67, 6.00, 9.33, 13.33, 16.67, 20.00, 18.12, 53.33, 51.33, 166.67, 333.33};
       Perime1 = new List<int> {200};
       Perime2 = new List<int> {200};
       Perime3 = new List<int> {200};
       Perime4 = new List<int> {200};
       Perime5 = new List<int> {200};
       Perime6 = new List<int> {200};
       Perime7 = new List<int> {0};
       Perime8 = new List<int> {0};
       Perime9 = new List<int> {0};
       Perime10 = new List<int> {0};
       Perime11 = new List<int> {0};
       Perime12 = new List<int> {0};
    }
}

