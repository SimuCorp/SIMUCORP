using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleuriste : PlayerClass
{
    public Fleuriste(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Rose", (300, 3.75, true, 1, 3) },
            { "Terreaux", (300, 3.50, true, 1, 3) },
            { "Pot de fleur", (300, 10.00, true, 1, 3) },
            { "Tulipe", (300, 6.00, true, 1, 3) },
            { "Pivoine", (300, 4.80, true, 1, 3) },
            { "Gerbera", (300, 3.00, true, 1, 3) },
            { "Iris", (0, 9.99, false, 1, 3) },
            { "Lys", (0, 9.99, false, 1, 3) },
            { "Bouquet de fleurs", (0, 45, false, 1, 3) },
            { "Cactus", (0, 11.34, false, 1, 3) },
            { "Camelia", (0, 11.00, false, 1, 3) },
            { "Couronne de fleurs", (0, 90, false, 1, 3) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 50 },
            { "Attractivité", 30 },
            { "Clientèle", 1000 },
            { "Panier", 15 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Rose", "Terreaux", "Pot de fleur", "Tulipe", "Pivoine", "Gerbera" };
        for (int i = 0; i < 6; ++i)
            _items.Add("NaN");
        _missingitems = new List<string> { "Iris", "Lys", "Bouquet de fleurs", "Cactus", "Camelia", "Couronne de fleurs"};
        materiel = new List<string> { "tableau de promotion", "décoration végétale", "décoration végétale", "nouvelles plantes" };
        prix = new List<double> {2.50, 2.33, 6.67, 4.00, 3.20, 2.00, 6.66, 6.66, 30, 7.56, 7.33, 60.00};
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
