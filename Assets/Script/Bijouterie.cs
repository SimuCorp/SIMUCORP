using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bijouterie : PlayerClass
{
    public Bijouterie(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Créoles en or", (50, 57, true, 1, 500) },
            { "Montre en argent", (50, 99, true, 1, 500) },
            { "Boucles d'oreilles fantaisie", (50, 24, true, 1, 500) },
            { "Pendentif", (50, 39, true, 1, 500) },
            { "Chaine en or", (50, 90, true, 1, 500) },
            { "Bracelet en or", (50, 150, true, 1, 500) },
            { "Collier en saphir", (0, 300, false, 1, 0) },
            { "Bague en or et saphir", (0, 200, false, 1, 0) },
            { "Montre en or", (0, 600, false, 1, 0) },
            { "Bague en diamant", (0, 1500, false, 1, 0) },
            { "Collier en diamant", (0, 4000, false, 1, 0) },
            { "Alliances", (0, 1000, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 70 },
            { "Attractivité", 90 },
            { "Clientèle", 95 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Créoles en or", "Montre en argent", "Boucles d'oreilles fantaisie", "Pendentif", "Chaine en or", "Bracelet en or"};
       for (int i = 0; i < 6; ++i)
          _items.Add("NaN");
        _missingitems = new List<string> { "Collier en saphir", "Bague en or et rubis", "Montre en or", "Bague en diamant", "Collier en diamant", "Alliances"};
        materiel = new List<string> { "tableau de promotion", "Réparation", "Cameras", "nouveaux bijoux" };
        prix = new List<double> {39, 66, 16, 26, 60, 100, 200, 133.33, 400.00, 1000.00, 2666.66, 666.66};
       Perime1 = new List<int> {50};
       Perime2 = new List<int> {50};
       Perime3 = new List<int> {50};
       Perime4 = new List<int> {50};
       Perime5 = new List<int> {50};
       Perime6 = new List<int> {50};
       Perime7 = new List<int> {0};
       Perime8 = new List<int> {0};
       Perime9 = new List<int> {0};
       Perime10 = new List<int> {0};
       Perime11 = new List<int> {0};
       Perime12 = new List<int> {0};
    }
}

