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
            { "Manga", (200, 7.90, true, 1, 500) },
            { "Livre de Poche", (200, 7.60, true, 1, 500) },
            { "Roman Policier", (200, 14.30, true, 1, 500) },
            { "Roman Science Fiction", (200, 8.32, true, 1, 500) },
            { "Roman d'amour", (200, 2.45, true, 1, 500) },
            { "Encyclopédie", (0, 15.50, false, 1, 0) },
            { "Livre de cuisine", (0, 12.50, false, 1, 0) },
            { "Bande Dessinée", (0, 10.90, false, 1, 0) },
            { "Documentaire", (0, 9.90, false, 1, 0) },
            { "Roman Horreur", (0, 14.30, false, 1, 0) },
            { "Livre Broché", (0, 17.90, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attractivité", 30 },
            { "Clientèle", 2000 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Livre de Fantaisie", "Manga", "Livre de Poche", "Roman Policier", "Roman Science Fiction", "Roman d'amour"};
		for (int i = 0; i < 6; ++i)
			_items.Add("NaN");
        _missingitems = new List<string> { "Encyclopédie", "Livre de cuisine", "Bande Dessinée", "Documentaire", "Roman Horreur", "Livre Broché"};
        materiel = new List<string> { "tableau de promotion", "Lecture", "Présentoire", "nouveaux livres" };
        prix = new List<double> {5.13, 5.27, 5.07, 9.53, 5.55, 1.63, 10.36, 8.33, 7.27, 6.66, 9.53, 11.93};
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
