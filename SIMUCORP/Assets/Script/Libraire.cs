using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libraire : PlayerClass
{
    public Libraire(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Livre de Fantaisie", (100, 7.70, true, 1, -1) },
            { "Manga", (250, 6.66, true, 1, -1) },
            { "Livre de Poche", (2000, 1.80, true, 1, -1) },
            { "Roman Policier", (200, 6.81, true, 1, -1) },
            { "Roman Science Fiction", (200, 8.32, true, 1, -1) },
            { "Nouvelle", (100, 2.08, true, 1, -1) },
            { "Encyclopédie", (0, 15.54, false, 1, -1) },
            { "Livre Dédicacé", (0, 12.50, false, 1, -1) },
            { "Bande Dessinée", (0, 6.54, false, 1, -1) },
            { "Saga Fantastique", (0, 25, false, 1, -1) },
            { "Roman Horreur", (0, 6.66, false, 1, -1) },
            { "Edition Collector", (0, 12.65, false, 1, -1) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attracivité", 20 },
            { "Clientèle", 2000 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Livre de Fantaisie", "Manga", "Livre de Poche", "Roman Policier", "Roman Science Fiction", "Nouvelle" };
        _missingitems = new List<string> { "Encyclopédie", "Livre Dédicacé", "Bande Dessinée", "Saga Fantastique", "Roman Horreur", "Edition Collector"};
        materiel = new List<string> { "tableau de promotion", "Etagère verticale", "Etagère horizontale", "nouveaux livres" };
        prix = new List<double> {5.13, 4.44, 1.20, 4.54, 5.55, 1.39, 10.36, 8.33, 4.36, 16.66, 4.44, 8.43};
    }
}
