using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coiffeur : PlayerClass
{
    public Coiffeur(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Coupe Homme", (100, 27, true, 1, 500) },
            { "Coupe Femme", (100, 32.7, true, 1, 500) },
            { "Mèches", (100, 130, true, 1, 500) },
            { "Barbe", (100, 25, true, 1, 500) },
            { "Soin", (100, 5, true, 1, 500) },
            { "Frange", (100, 15, true, 1, 500) },
            { "Coloration", (0, 25, false, 1, 0) },
            { "Shampoing + Coupe", (0, 50, false, 1, 0) },
            { "Brushing", (0, 33, false, 1, 0) },
            { "Permanente", (0, 85, false, 1, 0) },
            { "Coupe + Coloration", (0, 40.90, false, 1, 0) },
            { "Lissage brésilien", (0, 99, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attractivité", 80 },
            { "Clientèle", 85 },
            { "Panier", 35 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Coupe Homme", "Coupe Femme", "Mèches", "Barbe", "Soin", "Frange"};
		for (int i = 0; i < 6; ++i)
			_items.Add("NaN");
        _missingitems = new List<string> { "Coloration", "Shampoing + Coupe", "Brushing", "Permanente", "Shampoing + Coupe + Coloration", "Lissage brésilien"};
        materiel = new List<string> { "tableau de promotion", "desserte", "casque", "nouvelles coupes" };
        prix = new List<double> {18, 21.8, 86.67, 16.67, 3.33, 10, 16.67, 33.33, 22, 56.67, 27.27, 66};
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
