using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bijouterie : PlayerClass
{
    public Bijouterie(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Bague en argent", (20, 35, true, 1, 500) },
            { "Bracelet en argent", (20, 40, true, 1, 500) },
            { "Boucle d'oreilles en argent", (20, 20, true, 1, 500) },
            { "Bague breloque", (20, 15, true, 1, 500) },
            { "Chaine en argent", (20, 18, true, 1, 500) },
            { "Bracelet en acier", (20, 30, true, 1, 500) },
            { "Collier en saphir", (0, 300, false, 1, 0) },
            { "Bague en or et rubis", (0, 500, false, 1, 0) },
            { "Montre en or", (0, 600, false, 1, 0) },
            { "Bague en diamant", (0, 1500, false, 1, 0) },
            { "Collier en diamant", (0, 4000, false, 1, 0) },
            { "Montre en diamant", (0, 20000, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 40 },
            { "Attracivité", 90 },
            { "Clientèle", 40 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Bague en argent", "Bracelet en argent", "Boucles d'oreilles en argent", "Bague breloque", "Chaine en argent", "Bracelet en acier"};
       for (int i = 0; i < 6; ++i)
          _items.Add("NaN");
        _missingitems = new List<string> { "Collier en saphir", "Bague en or et rubis", "Montre en or", "Bague en diamant", "Collier en diamant", "Montre en diamant"};
        materiel = new List<string> { "tableau de promotion", "Fourniture d'atelier", "Décoration de luxe", "nouveaux bijoux" };
        prix = new List<double> {23.33, 26.66, 13.33, 10, 12, 20, 200, 333.33, 400.00, 1000.00, 2666.66, 13333.33};
       Perime1 = new List<int> {20};
       Perime2 = new List<int> {20};
       Perime3 = new List<int> {20};
       Perime4 = new List<int> {20};
       Perime5 = new List<int> {20};
       Perime6 = new List<int> {20};
       Perime7 = new List<int> {0};
       Perime8 = new List<int> {0};
       Perime9 = new List<int> {0};
       Perime10 = new List<int> {0};
       Perime11 = new List<int> {0};
       Perime12 = new List<int> {0};
    }
}

