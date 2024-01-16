using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coiffeur : PlayerClass
{
    public Coiffeur(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Coupe Homme", (500, 21.9, true, 1, 500) },
            { "Coupe Femme", (500, 32.7, true, 1, 500) },
            { "Shampoing", (500, 19.1, true, 1, 500) },
            { "Coupe Dégradé", (500, 25, true, 1, 500) },
            { "Frange", (500, 23, true, 1, 500) },
            { "Coupe Carrée", (500, 22, true, 1, 500) },
            { "Coloration", (0, 25, false, 1, 0) },
            { "Shampoing + Coupe", (0, 40.90, false, 1, 0) },
            { "Brushing", (0, 17, false, 1, 0) },
            { "Coupe Ondulée", (0, 27, false, 1, 0) },
            { "Coupe + Coloration", (0, 40.90, false, 1, 0) },
            { "Lissage brésilien", (0, 45, false, 1, 0) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 30 },
            { "Attracivité", 80 },
            { "Clientèle", 100 },
            { "Panier", 35 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Coupe Homme", "Coupe Femme", "Shampoing", "Coupe Dégradé", "Frange", "Coupe Carrée"};
		for (int i = 0; i < 6; ++i)
			_items.Add("NaN");
        _missingitems = new List<string> { "Coloration", "Shampoing + Coupe", "Brushing", "Coupe Ondulée", "Shampoing + Coupe + Coloration", "Lissage brésilien"};
        materiel = new List<string> { "tableau de promotion", "Siège massant", "Produit de coiffure", "nouvelles coupes" };
        prix = new List<double> {14.6, 21.8, 12.73, 16.67, 15.33, 14.67, 16.67, 27.27, 11.33, 18, 27.27, 30};
		Perime1 = new List<int> {500};
		Perime2 = new List<int> {500};
		Perime3 = new List<int> {500};
		Perime4 = new List<int> {500};
		Perime5 = new List<int> {500};
		Perime6 = new List<int> {500};
		Perime7 = new List<int> {0};
		Perime8 = new List<int> {0};
		Perime9 = new List<int> {0};
		Perime10 = new List<int> {0};
		Perime11 = new List<int> {0};
		Perime12 = new List<int> {0};
    }
}
