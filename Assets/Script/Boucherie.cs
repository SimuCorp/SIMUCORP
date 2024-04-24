using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boucherie : PlayerClass
{
    public Boucherie(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Steak Haché", (300, 3.30, true, 1, 3) },
            { "Saucisson", (300, 13.90, true, 1, 3) },
            { "Cuisse de poulet", (300, 3.70, true, 1, 3) },
            { "Saucisse", (300, 1.70, true, 1, 3) },
            { "Echine de porc", (300, 3.70, true, 1, 3) },
            { "Escalope de poulet", (300, 4.60, true, 1, 3) },
            { "Rôti de boeuf", (0, 30, false, 1, 3) },
            { "Poulet Rôti", (0, 12.50, false, 1, 3) },
            { "Merguez", (0, 1.70, false, 1, 3) },
            { "Lapin", (0, 25, false, 1, 3) },
            { "Roti de porc", (0, 9.00, false, 1, 3) },
            { "Brochette", (0, 5.78, false, 1, 3) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 60 },
            { "Attractivité", 20 },
            { "Clientèle", 1700 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Steak Haché", "Saucisson", "Cuisse de poulet", "Saucisse", "Echine de porc", "Escalope de poulet" };
		for (int i = 0; i < 6; ++i)
			_items.Add("NaN");
        _missingitems = new List<string> { "Rôti de boeuf", "Poulet Rôti", "Merguez", "Lapin", "Roti de porc", "Brochette"};
        materiel = new List<string> { "tableau de promotion", "Rotissoire", "Table de dégustation", "nouvelles viandes" };
        prix = new List<double> {2.20, 9.27, 2.46, 1.13, 2.46, 3.07, 20, 8.33, 1.13, 16.67, 6.00, 3.85};
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
