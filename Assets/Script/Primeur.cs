using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primeur : PlayerClass
{
	public Primeur(string name) : base(name)
	{
		_marchandise = new Dictionary<string, (int, double, bool, double, int)>()
		{
			{ "Tomate", (300, 0.33, true, 1, 3) },
			{ "Pomme", (300, 1.49, true, 1, 3) },
			{ "Salade", (300, 1.22, true, 1, 3) },
			{ "Carotte", (300, 2.13, true, 1, 3) },
			{ "Oignon", (300, 1.69, true, 1, 3) },
			{ "Banane", (300, 1.83, true, 1, 3) },
			{ "Petits Pois", (0, 3.29, false, 1, 3) },
			{ "Pomme de terre", (0, 1.20, false, 1, 3) },
			{ "Navet", (0, 1.98, false, 1, 3) },
			{ "Abricot", (0, 3.92, false, 1, 3) },
			{ "Fraises", (0, 11.00, false, 1, 3) },
			{ "Pasteque", (0, 5.78, false, 1, 3) }
		};
		_stat = new Dictionary<string, double>()
		{
			{ "Qualité", 50 },
			{ "Attractivité", 20 },
			{ "Clientèle", 5000 },
			{ "Panier", 15 },
			{ "Employé", 0 },
			{ "Salaire", 1399 },
			{ "Magasin", 1 },
		};
		_items = new List<string> { "Tomate", "Pomme", "Salade", "Carotte", "Oignon", "Banane" };
		for (int i = 0; i < 6; ++i)
			_items.Add("NaN");
		_missingitems = new List<string> { "Petits Pois", "Pomme de terre", "Navet", "Abricot", "Fraises", "Pasteque"};
		materiel = new List<string> { "tableau de promotion", "étalage fruit", "étalage légume", "nouveaux fruits et légumes" };
		prix = new List<double> {0.22, 1.0, 0.81, 1.42, 1.13, 1.22, 2.19, 0.80, 1.32, 2.61, 7.33, 3.85};
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


