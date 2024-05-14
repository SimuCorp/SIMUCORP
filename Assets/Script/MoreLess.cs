using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using static System.Math;
using static MoneyCount;
using static TextEmploye;
using static TextMagasin;
using static PlayerScript;
using static TextSalaire;

public class MoreLess : MonoBehaviour
{
    public void More(double value)
    {
        ++value;
    }
    
    public void Less(double value)
    {
		if (value > 0)
        	--value;
    }

    public void MoreEmploy()
    {
        ++TextEmploye.n;
    }
    
    public void LessEmploy()
    {
		if (TextEmploye.n > 0)
        	--TextEmploye.n;
    }

	public void MoreMagasin()
    {
        ++TextMagasin.n;
    }
    
    public void LessMagasin()
    {
		if (TextMagasin.n > 1)
        	--TextMagasin.n;
    }

	public void MoreSalaire()
    {
        TextSalaire.n += 10;
    }
    
    public void LessSalaire()
    {
		if (TextSalaire.n >= 1409)
        	TextSalaire.n -= 10;
    }
	public void MorePrice(int p)
	{
		PlayerClass gamer;
		
			gamer = Gamer1;
	
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == p)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.10, b, d, k);
	}

	public void LessPrice(int p)
	{
		PlayerClass gamer;
		
			gamer = Gamer1;

		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == p)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j <= 0.10)
			j += 0.10;
		gamer._marchandise[res] = (i, Round(j-0.10, 2), b, d, k);
	}

	public void MoreApro(int p)
	{
		PlayerClass gamer;
	
			gamer = Gamer1;

		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == p)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[p-1]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More1 += 5;
		}
	}

	public void MoreQuali(int p)
	{
		PlayerClass gamer;
		
			gamer = Gamer1;
	
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == p)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}
}
