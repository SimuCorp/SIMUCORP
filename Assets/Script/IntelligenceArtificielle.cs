using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static System.Math;
using static MoneyCount;
using static TourCount;
using static PlayerScript;

public class IntelligenceArtificielle : MonoBehaviour
{
	public static PlayerClass metier {get; set;}
	public static int act {get; set;}
	public static bool Perime {get; set;}

	public static double last_money {get; set;}
    // Start is called before the first frame update
    public IntelligenceArtificielle()
    {
		act = 10;
		Perime = false;
		last_money = 1500;
		metier = Gamer2;
		if (metier._name == "Primeur" || metier._name == "Boucher" || metier._name == "Poissonier" || metier._name == "Fleuriste")
			Perime = true;
    }
	public void Act10()
	{
		act = 10;
	}

	public void ActMoney()
	{
		last_money = metier._money;
	}
    public static void Achete()
    {

	    	for (int i = 0; i < 12; ++i)
			{
				if (metier._items[i] != "NaN")
				{
					double nb_magasin = metier._stat["Magasin"];
					(int Quantity, double price, bool possible, double promo, int tour) = metier._marchandise[metier._items[i]];
					if (tour == 3)
						Perime = true;
					bool b;
					if (Perime)
						b = (Quantity <= 100 || (((i == 0 && metier.Perime1[0] <= Quantity / 2) ||
					                        (i == 1 && metier.Perime2[0] <= Quantity / 2) ||
					                        (i == 2 && metier.Perime3[0] <= Quantity / 2) ||
					                        (i == 3 && metier.Perime4[0] <= Quantity / 2) ||
					                        (i == 4 && metier.Perime5[0] <= Quantity / 2) ||
					                        (i == 5 && metier.Perime6[0] <= Quantity / 2) ||
					                        (i == 6 && metier.Perime7[0] <= Quantity / 2) ||
					                        (i == 7 && metier.Perime8[0] <= Quantity / 2) ||
					                        (i == 8 && metier.Perime9[0] <= Quantity / 2) ||
					                        (i == 9 && metier.Perime10[0] <= Quantity / 2) ||
					                        (i == 10 && metier.Perime11[0] <= Quantity / 2) ||
					                        (i == 11 && metier.Perime12[0] <= Quantity / 2)) && TurnValues >= 3));
					else
						b = ((price <= 2 && Quantity < 100*nb_magasin) || (price <= 10 && Quantity < 50*nb_magasin) ||
					     (price <= 25 && Quantity < 25*nb_magasin) || (price <= 50 && Quantity < 10*nb_magasin) ||
					     (price <= 100 && Quantity < 4*nb_magasin) || (price > 100 && Quantity < nb_magasin));
					if (b)
					{
						if ((price <= 2 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 10 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 25 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 50 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 100 && metier.AddMoney(-metier.prix[i]*4*nb_magasin)) || (price > 100 && metier.AddMoney(-metier.prix[i]*nb_magasin)))
						{
							int j = 0;
							if (price <= 2)
								j = 5*(int)nb_magasin;
							else if (price <= 10)
								j = 5*(int)nb_magasin;
							else if (price <= 25)
								j = 5*(int)nb_magasin;
							else if (price <= 50)
								j = 5*(int)nb_magasin;
							else if (price <= 100)
								j = 4*(int)nb_magasin;
							else
								j = (int)nb_magasin;
							if (i == 0)
								metier.More1 += j;
							else if (i == 1)
								metier.More2 += j;
							else if (i == 2)
								metier.More3 += j;
							else if (i == 3)
								metier.More4 += j;
							else if (i == 4)
								metier.More5 += j;
							else if (i == 5)
								metier.More6 += j;
							else if (i == 6)
								metier.More7 += j;
							else if (i == 7)
								metier.More8 += j;
							else if (i == 8)
								metier.More9 += j;
							else if (i == 9)
								metier.More10 += j;
							else if (i == 10)
								metier.More11 += j;
							else
								metier.More12 += j;
							Quantity += j;
							metier._marchandise[metier._items[i]] = (Quantity, price, possible, promo, tour);
						}
					}
				}
			}
	}
	public static void LevelUp()
    {
		for (int i = 0; i < 12; ++i)
		{
			if (metier._items[i] != "NaN")
			{
				(int Quantity, double price, bool possible, double level, int tour) = metier._marchandise[metier._items[i]];
				double prix = 50*Pow(level, 2);
				if (metier._money >= 2*prix)
				{
					metier.AddMoney(-prix);
					++level;
				}
				metier._marchandise[metier._items[i]] = (Quantity, price, possible, level, tour);
			}
		}
	}
	public static void NewProduct()
    {
		for (int i = 6; i < 12; ++i)
		{
			if (metier._items[i] == "NaN" && metier._money >= 600)
			{
					metier.AddMoney(-300);
					metier._items[i] = metier._missingitems[i-6];
					metier._missingitems[i-6] = "acheté";
					(int a, double b, bool c, double d,int e) = metier._marchandise[metier._items[i]];
					metier._marchandise[metier._items[i]] = (a, b, true, d, e);
			}
		}
	}
	public static void DoAction()
	{
		if (act == 10 )
	    {
		    last_money = metier._money;
	    }
        if ( act > 0)
        {
			NewProduct();
	        for (int i = 0; i < 4; ++i)
	        {
				Achete();
			}
			if (metier.materiel[0] != "acheté" && metier.AddMoney(-300))
			{
				metier.materiel[0] = "acheté";
				metier.promo = true;
				metier._stat["Attractivité"] *= 1.33;
			}
	        else if (metier._money > 7_500 && TurnValues % 4 >= 1)
	        {
		        ++metier._stat["Magasin"];
		        ++metier._stat["Employé"];
		        metier.AddMoney(-5000);
	        }
			else if (metier._stat["Magasin"] > 1 && TurnValues % 4 >= 1 && metier._money < 1399*metier._stat["Employé"])
			{
				--metier._stat["Magasin"];
		        --metier._stat["Employé"];
				metier.AddMoney(1800);
			}
			else if (metier._money*2 > 1000*metier._stat["Employé"] && metier.AddMoney(-1000*metier._stat["Employé"]) && metier._stat["Employé"] != 0)
				metier._stat["Qualité"] += 2*metier._stat["Employé"];
			else if (metier._money > 5_000 && metier.materiel[2] != "acheté" && metier.AddMoney(-2500))
			{
				if (metier.materiel[1] != "acheté")
					metier.materiel[1] = "acheté";
				else
					metier.materiel[2] = "acheté";
				metier._stat["Attractivité"] += 5;
			}
			else if (metier._stat["Attractivité"] < 80 && metier._money > 5_000 && metier.AddMoney(-1000))
			{
				metier._stat["Attractivité"] += 5;
			}
			else if (metier._stat["Attractivité"] < 80 && metier._money > 2500 && metier.AddMoney(-500))
				metier._stat["Attractivité"] += 2.5;
			else if (metier._stat["Attractivité"] < 80 && metier._money > 1500 && metier.AddMoney(-100))
				metier._stat["Attractivité"] += 0.5;	 
			--act;
		}
		else if (act == 0)
		{
			if ((TourCount.TurnValues <= TourCount.MaxTurn))
			{
				LevelUp();
				metier._button = false;
				CalCulus(metier, "");
				last_money = metier._money;
				--act;
			}
		
		}
		else
			act = -1;
	}
	
}