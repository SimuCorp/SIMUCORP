using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pret_a_porter : PlayerClass
{
   public Pret_a_porter(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Tee-shirt", (100, 15, true, 1, 500) },
            { "Pull", (100, 40, true, 1, 500) },
            { "Sweat", (100, 30, true, 1, 500) },
            { "Jupe", (100, 14, true, 1, 500) },
            { "Chapeau", (100, 20, true, 1, 500) },
            { "Pantalon", (100, 45, true, 1, 500) },
            { "Robe", (0, 30, false, 1, 0) },
            { "Jean", (0, 45, false, 1, 0) },
            { "Manteau", (0, 200, false, 1, 0) },
            { "Chemisier", (0, 12, false, 1, 0) },
            { "Veste en cuir", (0, 330, false, 1, 0) },
            { "Costume", (0, 360, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attractivité", 40 },
            { "Clientèle", 250 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Tee-shirt", "Pull", "Sweat", "Jupe", "Chapeau", "Pantalon"};
       for (int i = 0; i < 6; ++i)
          _items.Add("NaN");
        _missingitems = new List<string> { "Robe", "Jean", "Manteau", "Chemisier", "Veste en cuir", "Costume"};
        materiel = new List<string> { "tableau de promotion", "Pressing", "Retouche", "nouveaux vêtements" };
        prix = new List<double> {10, 26.67, 20, 9.33, 13.33, 30.00, 20.00, 30, 133.67, 8.00, 220, 240};
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

