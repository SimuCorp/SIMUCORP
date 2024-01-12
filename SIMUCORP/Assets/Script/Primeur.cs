using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primeur : PlayerClass
{
	public Primeur(string name) : base(name)
	{
		_money = 2_500;
		_marchandise = new Dictionary<string, (int, double, bool, double, int)>()
		{
			{ "Tomate", (500, 0.33, true, 1, 3) },
			{ "Pomme", (500, 1.49, true, 1, 3) },
			{ "Salade", (500, 1.22, true, 1, 3) },
			{ "Carotte", (500, 2.13, true, 1, 3) },
			{ "Oignon", (500, 1.69, true, 1, 3) },
			{ "betterave", (500, 1.83, true, 1, 3) },
			{ "Petits Pois", (0, 3.29, false, 1, 3) },
			{ "Pomme de terre", (0, 1.20, false, 1, 3) },
			{ "Navet", (0, 1.98, false, 1, 3) },
			{ "Abricot", (0, 3.92, false, 1, 3) },
			{ "Fraise", (0, 11.00, false, 1, 3) },
			{ "Pasteque", (0, 5.78, false, 1, 3) }
		};
		_stat = new Dictionary<string, double>()
		{
			{ "Qualité", 50 },
			{ "Attracivité", 20 },
			{ "Clientèle", 5000 },
			{ "Panier", 15 },
			{ "Employé", 0 },
			{ "Salaire", 1399 },
			{ "Magasin", 1 },
		};
		_items = new List<string> { "Tomate", "Pomme", "Salade", "Carotte", "Oignon" };
		_turn = true;
		_commercial = new List<string> { "Promotion", "Publicité", "Carte de fidélité", "Cadeau" };
		_rh = new List<string> { "Employé", "Salaire", "Magasin", "Prime", };
		_gestion = new List<string> { "Prix", "Approvisionnement", "Qualité", "Matériels" };
		materiel = new List<string> { "tableau de promotion", "étalage fruit", "étalage légume", "nouveau fruit" };
	}
}


