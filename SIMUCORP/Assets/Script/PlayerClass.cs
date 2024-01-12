using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    public string _name { get; }
    public Dictionary<string, (int, double, bool, double, int)> _marchandise { get; set; } // Quantity; price; possible; ...; level
    public Dictionary<string, double> _stat { get; set; } // Name, Number
    public double _money { get; set; }
    
    public double _mounth { get; set; } // turnover

	public List<string> _items {get; set; }
	public bool _turn {get; set;}
    public bool _button {get; set;}
    public List<string> _commercial { get; set; }
    public List<string> _rh { get; set; }
    public List<string> _gestion { get; set; }
	public List<string> materiel { get; set; }
    public PlayerClass(string name)
    {
        _name = name;
        _mounth = 0;
		_button = true;
        _commercial = new List<string> { "Promotion", "Publicité", "Carte de fidélité", "Cadeau" };
		_rh = new List<string> { "Employé", "Salaire", "Magasin", "Prime",};
		_gestion = new List<string> { "Prix", "Approvisionnement", "Qualité", "Matériels" };

    }
    
    public bool AddMoney(double sum)
    {
        if (_money + sum >= 0)
        {
            _money += sum;
            _mounth += sum;
            return true;
        }

        return false;

    }
    
}
