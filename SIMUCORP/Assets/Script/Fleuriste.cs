using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleuriste : PlayerClass
{
    public Fleuriste(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Rose rouge", (300, 3.75, true, 1, 3) },
            { "Terreaux", (300, 3.50, true, 1, 3) },
            { "Pot de fleur", (300, 10.00, true, 1, 3) },
            { "Tulipe", (300, 6.00, true, 1, 3) },
            { "Pivoine", (300, 4.80, true, 1, 3) },
            { "Coquelicot", (300, 7.23, true, 1, 3) },
            { "œillet", (0, 9.99, false, 1, 3) },
            { "Rose blanche", (0, 9.99, false, 1, 3) },
            { "Bouquet de Lys", (0, 17.95, false, 1, 3) },
            { "Dahlia noir", (0, 11.34, false, 1, 3) },
            { "Camelia Rose", (0, 11.00, false, 1, 3) },
            { "Couronne de fleurs", (0, 45, false, 1, 3) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 50 },
            { "Attracivité", 30 },
            { "Clientèle", 1000 },
            { "Panier", 15 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Rose rouge", "Terreaux", "Pot de fleur", "Tulipe", "Pivoine", "Coquelicot" };
        for (int i = 0; i < 6; ++i)
            _items.Add("NaN");
        _missingitems = new List<string> { "œillet", "Rose blanche", "Bouquet de Lys", "Dahlia noir", "Camelia Rose", "Couronne de fleurs"};
        materiel = new List<string> { "tableau de promotion", "décoration végétale", "produits d'entretien", "nouvelles plantes" };
        prix = new List<double> {2.50, 2.33, 6.67, 4.00, 3.20, 4.82, 6.66, 6.66, 11.97, 7.56, 7.33, 30.00};
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
