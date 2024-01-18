using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poissonier : PlayerClass
{
    public Poissonier(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Maquereau", (300, 6.75, true, 1, 3) },
            { "Sardine", (300, 4.25, true, 1, 3) },
            { "Coquilles saint jacques", (300, 5.50, true, 1, 3) },
            { "Sole", (300, 14, true, 1, 3) },
            { "Merlan", (300, 8.50, true, 1, 3) },
            { "Hareng", (300, 9.00, true, 1, 3) },
            { "Saumon", (0, 22.45, false, 1, 3) },
            { "Salicorne", (0, 3.50, false, 1, 3) },
            { "Moule", (0, 7.50, false, 1, 3) },
            { "Crevettes", (0, 17, false, 1, 3) },
            { "Crabe", (0, 18, false, 1, 3) },
            { "Homard", (0, 49, false, 1, 3) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 50 },
            { "Attracivité", 20 },
            { "Clientèle", 1000 },
            { "Panier", 15 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Maquereau", "Sardine", "Coquilles saint jacques", "Sole", "Merlan", "Hareng" };
        for (int i = 0; i < 6; ++i)
            _items.Add("NaN");
        _missingitems = new List<string> { "Saumon", "Salicorne", "Moule", "Crevettes", "Crabe", "Homard"};
        materiel = new List<string> { "tableau de promotion", "Douchette de Nettoyage", "Etal à poisson", "nouvelles marchandises" };
        prix = new List<double> {4.50, 2.83, 3.66, 9.33, 5.67, 6.00, 14.97, 2.33, 5.00, 11.33, 12, 32.67};
        Perime1 = new List<int> {500};
        Perime2 = new List<int> {500};
        Perime3 = new List<int> {500};
        Perime4 = new List<int> {500};
        Perime5 = new List<int> {500};
        Perime6 = new List<int> {500};
        Perime7 = new List<int> {0};
        Perime8 = new List<int> {0};
        Perime9 = new List<int> {0};
        Perime10 = new List<int> {0};
        Perime11 = new List<int> {0};
        Perime12 = new List<int> {0};
    }
}
