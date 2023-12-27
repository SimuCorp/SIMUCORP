using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    public string _name { get; }
    public Dictionary<string, (int, double, bool)> _marchandise { get; set; } // Quantity; price; possible
    public Dictionary<string, int> _stat { get; set; } // Name, Number
    public double _money { get; set; }
    
    public double _mounth { get; set; } // turnover

	public List<string> _items {get; set; }
	public bool _turn {get; set;}
    
    public List<string> _commercial { get; set; }
    public List<string> _rh { get; set; }
    public List<string> _gestion { get; set; }
    public PlayerClass(string name)
    {
        _name = name;
        _mounth = 0;
        _commercial = new List<string>();
        _rh = new List<string>() { "", "", "", "" };
        _gestion = new List<string>();

    }
    
    public void AddMoney(double sum)
    {
        _money += sum;
        _mounth += sum;
    }
    
}
