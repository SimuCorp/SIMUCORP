using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poissonier : PlayerClass
{
    public Poissonier(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Maquereau", (300, 3.00, true, 1, 3) },
            { "Sardine", (300, 4.25, true, 1, 3) },
            { "Coquilles saint jacques", (300, 5.50, true, 1, 3) },
            { "Sole", (300, 11.73, true, 1, 3) },
            { "Merlan", (300, 5, true, 1, 3) },
            { "Cabillaud", (300, 13.20, true, 1, 3) },
            { "Saumon", (0, 8, false, 1, 3) },
            { "Salicorne", (0, 4.50, false, 1, 3) },
            { "Moules", (0, 9.90, false, 1, 3) },
            { "Crevettes", (0, 17, false, 1, 3) },
            { "Crabe", (0, 10, false, 1, 3) },
            { "Homard", (0, 15, false, 1, 3) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 50 },
            { "Attractivité", 20 },
            { "Clientèle", 1000 },
            { "Panier", 15 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Maquereau", "Sardine", "Coquilles saint jacques", "Sole", "Merlan", "Cabillaud" };
        for (int i = 0; i < 6; ++i)
            _items.Add("NaN");
        _missingitems = new List<string> { "Saumon", "Salicorne", "Moules", "Crevettes", "Crabe", "Homard"};
        materiel = new List<string> { "tableau de promotion", "Aquarium", "Table de dégustation", "nouvelles marchandises" };
        prix = new List<double> {2.00, 2.83, 3.66, 7.82, 3.33, 8.80, 5.33, 3, 6.60, 11.33, 6.67, 10};
        Perime1 = new List<int> {300};
        Perime2 = new List<int> {300};
        Perime3 = new List<int> {300};
        Perime4 = new List<int> {300};
        Perime5 = new List<int> {300};
        Perime6 = new List<int> {300};
        Perime7 = new List<int> {0};
        Perime8 = new List<int> {0};
        Perime9 = new List<int> {0};
        Perime10 = new List<int> {0};
        Perime11 = new List<int> {0};
        Perime12 = new List<int> {0};
    }
}
