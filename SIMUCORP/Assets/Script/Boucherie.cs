using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boucherie : PlayerClass
{
    public Boucherie(string name) : base(name)
    {
        _marchandise = new Dictionary<string, (int, double, bool, double, int)>()
        {
            { "Steak Haché", (500, 3.30, true, 1, 3) },
            { "Saucisson", (250, 6.65, true, 1, 3) },
            { "Ailes de poulet", (500, 2.95, true, 1, 3) },
            { "Saucisses", (500, 6.81, true, 1, 3) },
            { "Echine de porc", (500, 10.97, true, 1, 3) },
            { "Brechet de poulet", (500, 2.08, true, 1, 3) },
            { "Rôti de boeuf", (0, 14.66, false, 1, 3) },
            { "Poulet Rôti", (0, 12.50, false, 1, 3) },
            { "Merguez", (0, 4.16, false, 1, 3) },
            { "Lapin", (0, 6.50, false, 1, 3) },
            { "Sanglier", (0, 6.66, false, 1, 3) },
            { "Cheval", (0, 5.78, false, 1, 3) }
        };
        _stat = new Dictionary<string, double>()
        {
            { "Qualité", 60 },
            { "Attracivité", 30 },
            { "Clientèle", 3000 },
            { "Panier", 25 },
            { "Employé", 0 },
            { "Salaire", 1399 },
            { "Magasin", 1 },
        };
        _items = new List<string> { "Steak Haché", "Saucisson", "Ailes de poulet", "Saucisses", "Echine de porc", "Brechet de poulet" };
        _missingitems = new List<string> { "Rôti de boeuf", "Poulet Rôti", "Merguez", "Lapin", "Sanglier", "Cheval"};
        materiel = new List<string> { "tableau de promotion", "rotissoire", "couteaux", "nouvelles viandes" };
        prix = new List<double> {2.20, 4.43, 1.97, 4.54, 7.31, 1.39, 9.77, 8.33, 2.77, 4.33, 4.44, 3.85};
    }
}
