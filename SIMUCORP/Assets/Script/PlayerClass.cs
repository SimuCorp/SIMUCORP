using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    public string _name { get; }
    public Dictionary<string, (int, double, bool)> _marchandise { get; set; } // Quantity; price; possible
    public Dictionary<string, int> _stat { get; set; } // Name, Number
    public float _money { get; set; }
    
    public float _mounth { get; set; } // turnover

    public PlayerClass(string name)
    {
        _name = name;
        _mounth = 0;
        if (name == "Primeur")
            MakePrimeur();
    }

    public void AddMoney(float sum)
    {
        _money += sum;
        _mounth += sum;
    }

    public  void MakePrimeur()
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
            { "Attracivité", 30 },
            { "Clientèle", 300 },
            { "Panier", 15 }
        };
    }
    
}
