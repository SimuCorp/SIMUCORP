using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mirror;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static PlayerScript;
using static MoneyCount;

public class ButtonMateriel : NetworkBehaviour 
{
   public void Materiel1()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        if (gamer.materiel[0] != "acheté" && gamer.AddMoney(-200))
        {
           gamer.materiel[0] = "acheté";
           gamer._stat["Attractivité"] += 0.01;
        }
    }
   
   public void Materiel2()
   {
	  PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
      if (gamer.materiel[1] != "acheté" && gamer.AddMoney(-2500))
      {
         gamer.materiel[1] = "acheté";
         gamer._stat["Attractivité"] += 5;
      }
   }
   
   public void Materiel3()
   {
      PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
      if (gamer.materiel[2] != "acheté" && gamer.AddMoney(-2500))
      {
         gamer.materiel[2] = "acheté";
         gamer._stat["Attractivité"] += 5;
      }
   }

	public void Materiel5()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[0] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 7)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[0] = "acheté";
			gamer._items[6] = s;
		}
	}

	public void Materiel6()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[1] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 8)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[1] = "acheté";
			gamer._items[7] = s;
		}
	}

	public void Materiel7()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[2] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 9)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[2] = "acheté";
			gamer._items[8] = s;
		}
	}

	public void Materiel8()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[3] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 10)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[3] = "acheté";
			gamer._items[9] = s;
		}
	}

	public void Materiel9()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[4] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 11)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[4] = "acheté";
			gamer._items[10] = s;
		}
	}

	public void Materiel10()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[5] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 12)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[5] = "acheté";
			gamer._items[11] = s;
		}
	}
   
}
