using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    public string _name { get; }
    public Dictionary<string, (int, double, bool, double, int)> _marchandise { get; set; } // Quantity; price; possible; level; turn
    public Dictionary<string, double> _stat { get; set; } // Name, Number
    public double _money { get; set; }
    
    public double _mounth { get; set; } // turnover

	public List<string> _items {get; set; }
    public List<string> _missingitems {get; set; }
	public bool _turn {get; set;}
    public bool _button {get; set;}
	public bool promo {get; set;}
    public List<string> _commercial { get; set; }
    public List<string> _rh { get; set; }
    public List<string> _gestion { get; set; }
	public List<string> materiel { get; set; }
    public List<double> prix { get; set; }

    public List<int> Perime1 {get; set;}
	public List<int> Perime2 {get; set;}
	public List<int> Perime3 {get; set;}
	public List<int> Perime4 {get; set;}
	public List<int> Perime5 {get; set;}
	public List<int> Perime6 {get; set;}
	public List<int> Perime7 {get; set;}
	public List<int> Perime8 {get; set;}
	public List<int> Perime9 {get; set;}
	public List<int> Perime10 {get; set;}
	public List<int> Perime11 {get; set;}
	public List<int> Perime12 {get; set;}

	public int More1 {get; set;}
	public int More2 {get; set;}
	public int More3 {get; set;}
	public int More4 {get; set;}
	public int More5 {get; set;}
	public int More6 {get; set;}
	public int More7 {get; set;}
	public int More8 {get; set;}
	public int More9 {get; set;}
	public int More10 {get; set;}
	public int More11 {get; set;}
	public int More12 {get; set;}
	
	public float TimeLeft { get; set; }
	public float nbCount {get; set;}

	public bool ready {get; set;}
	public bool tour {get; set;}
	public double sum {get; set;}

    public PlayerClass(string name)
    {
        _name = name;
        _mounth = 0;
		_button = true;
		_turn = true;
		_money = 1_500;
        _commercial = new List<string> { "Promotion", "Publicité", "Carte de fidélité", "Cadeau" };
		_rh = new List<string> { "Employé", "Salaire", "Magasin", "Prime",};
		_gestion = new List<string> { "Prix", "Approvisionnement", "Qualité", "Matériels" };
		promo = false;

		More1 = 0;
		More2 = 0;
		More3 = 0;
		More4 = 0;
		More5 = 0;
		More6 = 0;
		More7 = 0;
		More8 = 0;
		More9 = 0;
		More10 = 0;
		More11 = 0;
		More12 = 0;

		TimeLeft = 120;
		nbCount = 1;
		ready = false;
		sum = 0;
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
