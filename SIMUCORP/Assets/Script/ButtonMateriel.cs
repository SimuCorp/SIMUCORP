using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;

public class ButtonMateriel : MonoBehaviour
{
   public void Materiel1()
   {
      if (Gamer1.materiel[0] != "done" && Gamer1.AddMoney(-200))
      {
         Gamer1.materiel[0] = "done";
         Gamer1._stat["Attracivité"] += 0.01;
      }
   }
   
   public void Materiel2()
   {
      if (Gamer1.materiel[1] != "done" && Gamer1.AddMoney(-2500))
      {
         Gamer1.materiel[1] = "done";
         Gamer1._stat["Attracivité"] += 5;
      }
   }
   
   public void Materiel3()
   {
      if (Gamer1.materiel[2] != "done" && Gamer1.AddMoney(-2500))
      {
         Gamer1.materiel[2] = "done";
         Gamer1._stat["Attracivité"] += 5;
      }
   }

	public void Materiel5()
	{
		if(Gamer1._missingitems[0] != "done" && Gamer1.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in Gamer1._marchandise.Keys)
			{
				if (i == 7)
				{
					(a, b, c, d, e) = Gamer1._marchandise[res];
					s = res;
				}
				++i;
			}
			Gamer1._marchandise[s] = (a, b, true, d, e);
			Gamer1._missingitems[0] = "done";
			Gamer1._items.Add(s);
		}
	}

	public void Materiel6()
	{
		if(Gamer1._missingitems[1] != "done" && Gamer1.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in Gamer1._marchandise.Keys)
			{
				if (i == 8)
				{
					(a, b, c, d, e) = Gamer1._marchandise[res];
					s = res;
				}
				++i;
			}
			Gamer1._marchandise[s] = (a, b, true, d, e);
			Gamer1._missingitems[1] = "done";
			Gamer1._items.Add(s);
		}
	}

	public void Materiel7()
	{
		if(Gamer1._missingitems[2] != "done" && Gamer1.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in Gamer1._marchandise.Keys)
			{
				if (i == 9)
				{
					(a, b, c, d, e) = Gamer1._marchandise[res];
					s = res;
				}
				++i;
			}
			Gamer1._marchandise[s] = (a, b, true, d, e);
			Gamer1._missingitems[2] = "done";
			Gamer1._items.Add(s);
		}
	}

	public void Materiel8()
	{
		if(Gamer1._missingitems[3] != "done" && Gamer1.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in Gamer1._marchandise.Keys)
			{
				if (i == 10)
				{
					(a, b, c, d, e) = Gamer1._marchandise[res];
					s = res;
				}
				++i;
			}
			Gamer1._marchandise[s] = (a, b, true, d, e);
			Gamer1._missingitems[3] = "done";
			Gamer1._items.Add(s);
		}
	}

	public void Materiel9()
	{
		if(Gamer1._missingitems[4] != "done" && Gamer1.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in Gamer1._marchandise.Keys)
			{
				if (i == 11)
				{
					(a, b, c, d, e) = Gamer1._marchandise[res];
					s = res;
				}
				++i;
			}
			Gamer1._marchandise[s] = (a, b, true, d, e);
			Gamer1._missingitems[4] = "done";
			Gamer1._items.Add(s);
		}
	}

	public void Materiel10()
	{
		if(Gamer1._missingitems[5] != "done" && Gamer1.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in Gamer1._marchandise.Keys)
			{
				if (i == 12)
				{
					(a, b, c, d, e) = Gamer1._marchandise[res];
					s = res;
				}
				++i;
			}
			Gamer1._marchandise[s] = (a, b, true, d, e);
			Gamer1._missingitems[5] = "done";
			Gamer1._items.Add(s);
		}
	}
   
}
