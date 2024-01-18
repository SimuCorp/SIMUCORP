using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libraire : PlayerClass
{
    public Libraire(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Livre de Fantaisie", (200, 7.70, true, 1, 500) },
            { "Manga", (200, 6.66, true, 1, 500) },
            { "Livre de Poche", (200, 1.80, true, 1, 500) },
            { "Roman Policier", (200, 6.81, true, 1, 500) },
            { "Roman Science Fiction", (200, 8.32, true, 1, 500) },
            { "Nouvelle", (200, 2.08, true, 1, 500) },
            { "Encyclopédie", (0, 15.54, false, 1, 0) },
            { "Livre Dédicacé", (0, 12.50, false, 1, 0) },
            { "Bande Dessinée", (0, 6.54, false, 1, 0) },
            { "Saga Fantastique", (0, 25, false, 1, 0) },
            { "Roman Horreur", (0, 6.66, false, 1, 0) },
            { "Edition Collector", (0, 12.65, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attracivité", 30 },
            { "Clientèle", 2000 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Livre de Fantaisie", "Manga", "Livre de Poche", "Roman Policier", "Roman Science Fiction", "Nouvelle"};
		for (int i = 0; i < 6; ++i)
			_items.Add("NaN");
        _missingitems = new List<string> { "Encyclopédie", "Livre Dédicacé", "Bande Dessinée", "Saga Fantastique", "Roman Horreur", "Edition Collector"};
        materiel = new List<string> { "tableau de promotion", "Etagère verticale", "Etagère horizontale", "nouveaux livres" };
        prix = new List<double> {5.13, 4.44, 1.20, 4.54, 5.55, 1.39, 10.36, 8.33, 4.36, 16.66, 4.44, 8.43};
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
