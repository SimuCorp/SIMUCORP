using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primeur : PlayerClass
{
    public Primeur(string name):base(name)
	{
		_money = 10_000;
        _marchandise = new Dictionary<string, (int, double, bool)>()
        {
            { "Tomate", (500, 0.33, true) },
            { "Pomme", (500, 1.49, true) },
            { "Pomme de terre", (0, 1.20, false) },
            { "Salade", (500, 1.22, true) },
            { "Carotte", (500, 2.13, true) },
            { "Petits Pois", (0, 3.29, false) },
            { "Oignon", (500, 1.69, true) },
            { "Navet", (0, 1.98, false) },
            { "Abricot", (0, 3.92, false) },
            { "Fraise", (0, 11.00, false) },
            { "Pasteque", (0, 5.78, false) }
        };
        _stat = new Dictionary<string, int>()
        {
            { "Qualité", 50 },
            { "Attracivité", 20 },
            { "Clientèle", 5000 },
            { "Panier", 15 },
			{ "Employer", 0},
			{ "Magasin", 0},
        };
		_items = new List<string> {"Tomate", "Pomme", "Salade", "Carotte", "Oignon"};
		_turn = true;
	}
}


