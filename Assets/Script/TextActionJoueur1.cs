using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static PlayerScript;
using static Player1Script;
using static MoneyCount;
using static System.Math;

using static FinDeTour;

public class TextActionJoueur1 : MonoBehaviour
{

    public static Text action;
	public AudioSource audio;
	public AudioSource FinTour;
	public GameObject Text_action;
	public Image Emplacement1;
	public Image Emplacement2;
	public Sprite fond;
	public Sprite Amelioration1;
    public Sprite Amelioration2;
	public bool end;
	[SerializeField] private GameObject GameOver;
	[SerializeField] private GameObject FinDeTour;
	[SerializeField] private GameObject ElementTour;
	public static double Vente1;
    public static double Vente2;
	public static double Collision;
    // Start is called before the first frame update
    void Start()
    {
        action = GetComponent<Text>();
		audio = GetComponent<AudioSource>();
		FinTour = GetComponent<AudioSource>();
		end = false;
		Emplacement1.sprite = fond;
		Emplacement2.sprite = fond;
		Vente1 = 0;
		Vente2 = 0;
    }

    // Update is called once per frame
    void Update()
    {	
		double x = Text_action.transform.position.x;
		double x2 = Screen.width/2;
		if (FinDeTour.activeSelf && Gamer1.TimeLeft < 120)
		{
			FinDeTour.SetActive(false);
			move = true;
		}
		if (((true && x <= x2) || (!true && x >= x2)))
		{
			PlayerClass gamer;
	
				gamer = Gamer1;
		
			move = action.text == "" && gamer._button && !PlayerScript.pause && !FinDeTour.activeSelf;
			if (Gamer1.TimeLeft <= 0)
            {
                if (Gamer1._button && Gamer2._button)
                {
                    Gamer1._button = false;
                    CalCulus(Gamer1);
                    Gamer2._button = false;
                    CalCulus(Gamer2);
                }
                else if (Gamer2._button)
                {
                    Gamer2._button = false;
                    CalCulus(Gamer1);
                }
                else
                {
                       Gamer1._button = false;
                       CalCulus(Gamer1);
                }
            }
			if (action.text.Length != 0)
				ChangementText(Player1Script.act, true);
			if (Input.GetKeyDown(KeyCode.Backspace))
			{
				Player1Script.move = gamer._button && Gamer1.TimeLeft < 120;
				action.text = "";
			}
			if (action.text == (gamer.materiel[1] + " : 2500 $") && Input.GetKeyDown(KeyCode.Return))
			{
				if (gamer._money < 2500)
					action.color = Color.red;
				else
				{
					action.color = Color.green;
					audio.Play();
					Emplacement1.sprite = Amelioration1;
				}
				 MoreMaterielAOpponent(1);
				Player1Script.move = true;
				action.text = "";
			}
			else if (action.text == (gamer.materiel[2] + " : 2500 $") && Input.GetKeyDown(KeyCode.Return))
			{
				if (gamer._money < 2500)
					action.color = Color.red;
				else
				{
					action.color = Color.green;
					audio.Play();
					Emplacement2.sprite = Amelioration2;
				}
				 MoreMaterielAOpponent(2);
				Player1Script.move = true;
				action.text = "";
			}
			else if (action.text == gamer._missingitems[Player1Script.act%6] + " : 300 $" && Input.GetKeyDown(KeyCode.Return))
			{
				string s = gamer._missingitems[Player1Script.act%6];
				MoreMaterielGOpponent(Player1Script.act+1, s);
				if (action.color == Color.green)
				{
					audio.Play();
				}
				if( gamer._missingitems[act-6] == "acheté")
				{
					int a = 0;
					double b = 0;
					bool c = false;
					double d = 0;
					int e = 0;
					(a, b, c, d, e) = gamer._marchandise[s];
					action.text = "Quantité de " + gamer._items[act-6] + $" : {a}";
				}
			}
			else if (action.text.StartsWith("Quantité"))
			{
				string item = gamer._items[Player1Script.act];
				if (Input.GetKeyDown(KeyCode.Return))
				{
					MoreAproOpponent(item);
					if (action.color == Color.green)
					{
						audio.Play();
					}
				}
				(int n, double j, bool b, double d, int k)= gamer._marchandise[item];
				if (j*5>gamer._money)
						TextActionJoueur1.action.color = Color.red;
				else 
						TextActionJoueur1.action.color = Color.green;
				action.text = "Quantité de " + item + $" : {n}";
			}
			else if (action.text.StartsWith("Prix de"))
			{
				string item = gamer._items[Player1Script.act];
				if (Input.GetKeyDown(KeyCode.RightArrow))
				{
					MorePriceOpponent(item);
					audio.Play();
				}
				else if (Input.GetKeyDown(KeyCode.LeftArrow))
				{
					LessPriceOpponent(item);
					audio.Play();
				}
				(int n, double j, bool b, double d, int k)= gamer._marchandise[item];
				TextActionJoueur1.action.color = Color.green;
				action.text = "Prix de " + item + $" : {Round(j,2)} $";
			}
			else if (action.text.Contains("de niveau"))
			{
				int i = 0;
				string[] mot = action.text.Split(" ");
				string item = gamer._items[Player1Script.act];
				if (Input.GetKeyDown(KeyCode.Return))
				{
					MoreQualiOpponent(item);
					if (action.color == Color.green)
						audio.Play();
				}
				(int n, double j, bool b, double d, int k)= gamer._marchandise[item];
				action.text =  item + " de niveau " +$"{d}"+$" : {50*Pow(d, 2)} $";
				if (50*Pow(d, 2) > gamer._money)
					TextActionJoueur1.action.color = Color.red;
				else 
					TextActionJoueur1.action.color = Color.green;
				
			}
			else if (TextActionJoueur1.action.text.Contains("employés"))
			{
				if (gamer._money < 700 || gamer._stat["Employé"] <= 0)
					TextActionJoueur1.action.color = Color.red;
				else
					TextActionJoueur1.action.color = Color.green;
				if (Input.GetKeyDown(KeyCode.LeftArrow))
				{
					EmployeOpponent(false);
					if (action.color == Color.green)
						audio.Play();
				}
				else if (Input.GetKeyDown(KeyCode.RightArrow))
				{
					EmployeOpponent(true);
					audio.Play();
				}
				TextActionJoueur1.action.text = $"Nombre d'employés : {gamer._stat["Employé"]}";
			}
			else if (TextActionJoueur1.action.text.Contains("Salaire"))
			{
				if (gamer._stat["Salaire"] == 1399)
					TextActionJoueur1.action.color = Color.red;
				else
					TextActionJoueur1.action.color = Color.green;
				if (Input.GetKeyDown(KeyCode.LeftArrow))
				{
					salaireOpponent(false);
					if (action.color == Color.green)
						audio.Play();
				}
				else if (Input.GetKeyDown(KeyCode.RightArrow))
				{
					salaireOpponent(true);
					audio.Play();
				}
				TextActionJoueur1.action.text = $"Salaire : {gamer._stat["Salaire"]} $";
			}
			else if (TextActionJoueur1.action.text.Contains("magasins"))
			{
				if (gamer._money >= 5000 && gamer._stat["Employé"]+1 >= gamer._stat["Magasin"])
					action.color = Color.green;
				else
					action.color = Color.red;
				if (Input.GetKeyDown(KeyCode.LeftArrow) && gamer._stat["Magasin"] != 1)
				{
					magasinOpponent(false);
					audio.Play();
				}
				else if (Input.GetKeyDown(KeyCode.RightArrow))
				{
					magasinOpponent(true);
					audio.Play();
				}
				TextActionJoueur1.action.text = $"Nombre de magasins : {gamer._stat["Magasin"]}";
			}
			else if (TextActionJoueur1.action.text.Contains("Prime"))
			{
				if (gamer._money >= 1000*gamer._stat["Employé"] && gamer._stat["Employé"]!= 0)
					action.color = Color.green;
				else
					action.color = Color.red;
				if (Input.GetKeyDown(KeyCode.Return))
				{
					primeOpponent();
					if(action.color == Color.green && gamer._stat["Employé"] != 0)
						audio.Play();
				}
			}
			else if (TextActionJoueur1.action.text.Contains("romotion"))
			{
				if (gamer.materiel[0] != "acheté")
				{
					if (gamer._money < 300)
						TextActionJoueur1.action.color = Color.red;
					else
						TextActionJoueur1.action.color = Color.green;
					if (action.color == Color.green && Input.GetKeyDown(KeyCode.Return))
					{
						PromoOpponent();
					
						action.text = "Promotion en attente";
						audio.Play();
					}
				}
				else
				{
					TextActionJoueur1.action.color = Color.green;
					if (Input.GetKeyDown(KeyCode.Return))
					{
						PromoOpponent();
						audio.Play();
					}
					if (gamer.promo)
						TextActionJoueur1.action.text = "Promotion en cours";
					else
						TextActionJoueur1.action.text = "Promotion en attente";
				}
			}
			else if (TextActionJoueur1.action.text.Contains("Cartes"))
			{
				if (gamer._money < 100)
					action.color = Color.red;
				else
					action.color = Color.green;
				if (Input.GetKeyDown(KeyCode.Return))
				{
					carteOpponent();
					if (action.color == Color.green)
						audio.Play();
				}
			}
			else if (TextActionJoueur1.action.text.Contains("Cadeaux"))
			{
				if (gamer._money < 500)
					action.color = Color.red;
				else
					action.color = Color.green;
				if (Input.GetKeyDown(KeyCode.Return))
				{
					cadeauOpponent();
					if (action.color == Color.green)
						audio.Play();
				}
			}
			else if (TextActionJoueur1.action.text.Contains("Publicité"))
			{
				if (gamer._money < 1000)
					action.color = Color.red;
				else
					action.color = Color.green;
				if (Input.GetKeyDown(KeyCode.Return))
				{
					pubOpponent();
					if(action.color == Color.green)
						audio.Play();
				}
			}
			else if (TextActionJoueur1.action.text.Contains("Finir"))
			{
				if (Input.GetKeyDown(KeyCode.Return))
				{
					OpponentCalcul();
					TextActionJoueur1.action.text = "";
					//Player1Script.move = !end;
				}
			}
			else
			{
			ChangementText(Player1Script.act, true);
			}
		}
	}

	public void MoreMaterielAOpponent(int p)
	{
	
			AMateriel(p, true);
		
	}

	
   public void AMateriel(int p, bool joueur)
   {
	  PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
      if (gamer.materiel[p] != "acheté" && gamer.AddMoney(-2500))
      {
         gamer.materiel[p] = "acheté";
         gamer._stat["Attractivité"] += 5;
		 if (p == 1)
			Player1Script.amelioration1 = false;
		else
			Player1Script.amelioration2 = false;
	  }
   }
   
	public void MoreMaterielGOpponent(int p, string s)
	{
	
			MaterielG(p, s, true);
	
	}


    public void MaterielG(int p, string s, bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[p-7] != "acheté" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			(a, b, c, d, e) = gamer._marchandise[s];
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[p-7] = "acheté";
			gamer._items[p-1] = s;
			double x = Text_action.transform.position.x;
			double x2 = Screen.width/2;
			if ((true && x <= x2) || (!true && x >= x2))
				action.text = "Quantité de " + gamer._items[p-1] + $" : {a}";
		}
		else
		{
			Player1Script.move = true;
		}
	}

	public void MoreAproOpponent(string item)
	{
		
	
			MoreApro(item, true);
	
	
	}


	public void MoreApro(string item, bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		(int i, double j, bool b, double d, int k)= gamer._marchandise[item];
		if (b && gamer.AddMoney(-gamer.prix[Player1Script.act]*5))
		{
			gamer._marchandise[item] = (i+5, j, b, d, k);
			switch (Player1Script.act+1)
			{
				case 1:
					gamer.More1 += 5;
					break;
				case 2:
					gamer.More2 += 5;
					break;
				case 3:
					gamer.More3 += 5;
					break;
				case 4:
					gamer.More4 += 5;
					break;
				case 5:
					gamer.More5 += 5;
					break;
				case 6:
					gamer.More6 += 5;
					break;
				case 7:
					gamer.More7 += 5;
					break;
				case 8:
					gamer.More8 += 5;
					break;
				case 9:
					gamer.More9 += 5;
					break;
				case 10:
					gamer.More10 += 5;
					break;
				case 11:
					gamer.More11 += 5;
					break;
				case 12:
					gamer.More12 += 5;
					break;
			}
		}
	}
	public void MorePriceOpponent(string item)
	{
	
			MorePrice(item, true);
	
	
	}

	public void MorePrice(string item, bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
        (int i, double j, bool b, double d, int k)= gamer._marchandise[item];
		gamer._marchandise[item] = (i, j+0.10, b, d, k);
		
	}
	public void LessPriceOpponent(string item)
	{
		
			LessPrice(item, true);
	
	}



	public void LessPrice(string item, bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;

        (int i, double j, bool b, double d, int k)= gamer._marchandise[item];
		if (j <= 0.10)
			j += 0.10;
		gamer._marchandise[item] = (i, Round(j-0.10, 2), b, d, k);
	}

	public void MoreQualiOpponent(string item)
	{
		
			MoreQuali(item, true);
	
	}

	public void MoreQuali(string item, bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		(int i, double j, bool b, double d, int k)= gamer._marchandise[item];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[item] = (i, j, b, d+1, k);
		}
	}

	public void EmployeOpponent(bool verif)
	{
		
			Employe(verif, true);
	
	}
	
	public void Employe(bool verif, bool joueur)
    {
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
			if (verif)
			{
				++gamer._stat["Employé"];
			}
			else if (gamer._stat["Magasin"] <= gamer._stat["Employé"] && gamer.AddMoney(-700))
			{
				--gamer._stat["Employé"];
			}


    }


	public void salaireOpponent(bool verif)
	{
		
			Salaire(verif, true);
		
	}

	
	public void Salaire(bool verif, bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;

			if (verif)
			{
				gamer._stat["Qualité"] += 1*gamer._stat["Employé"]; 
				gamer._stat["Salaire"] += 10;
			}
			else if (gamer._stat["Salaire"] != 1399)
			{
				gamer._stat["Qualité"] -= 1*gamer._stat["Employé"]; 
				gamer._stat["Salaire"] -= 10;
			}
		
	}


	public void magasinOpponent(bool verif)
	{
		
			Magasin(verif, true);
	
		
	}

	
	public void Magasin(bool verif, bool joueur)
    {
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        double n1 = gamer._stat["Magasin"];
			if (n1 - 1 <= gamer._stat["Employé"])
			{
				if (verif && gamer.AddMoney(-5000))
					++gamer._stat["Magasin"];
			}
			if (!verif)
			{
				gamer.AddMoney(2500);
				--gamer._stat["Magasin"];
			}
	
    }

	public void primeOpponent()
	{
	
			Prime(true);
		
	}

	public void Prime(bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer.AddMoney(-1000*gamer._stat["Employé"]) && gamer._stat["Employé"] != 0)
			gamer._stat["Qualité"] += 2*gamer._stat["Employé"];
	}

	public void PromoOpponent()
	{
		
			Promotion(true);
		
	}


	public void Promotion(bool joueur)
    {
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer.materiel[0] == "acheté")
        {
			gamer.promo = !gamer.promo;
			if (gamer.promo)
				gamer._stat["Attractivité"] *= 1.33;
			else
				gamer._stat["Attractivité"] /= 1.33;
		}
		else if(gamer.AddMoney(-300))
		{
			gamer.materiel[0] = "acheté";
		}
    }


	public void carteOpponent()
	{
		
			Carte(true);
	
	}

	public void Carte(bool joueur)
    {
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer.AddMoney(-100))
			gamer._stat["Attractivité"] += 0.5;
    }


	public void cadeauOpponent()
	{
		
			Carte(true);
	
	}

	
	public void Cadeau(bool joueur)
    {
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if( gamer.AddMoney(-500))
			gamer._stat["Attractivité"] += 2.5;
    }


	public void pubOpponent()
	{
	
			Pub(true);
	

	}

	
	public void Pub(bool joueur)
    {
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer.AddMoney(-1000))
			gamer._stat["Attractivité"] += 5;
    }

	public void OpponentCalcul()
	{
	
			calcul(true);
	

	}




	public void calcul(bool joueur)
	{
		if (joueur)
		{
			if(Gamer1._button)
			{

				Gamer1._button = false;
				CalCulus(Gamer1);
			}
		}
		else
		{
			if(Gamer2._button)
			{
				Gamer2._button = false;
				CalCulus(Gamer2);
			}
		}
	}

	public void CalCulus(PlayerClass gamer)
    {
        System.Random aleatoire = new System.Random();
        double attractive = gamer._stat["Attractivité"];
        double client = gamer._stat["Clientèle"];
        int nb_client = aleatoire.Next((int)Round(client / 2, 0), (int)Round(client * 2, 0));
        int key;
        if (gamer._turn)
        {
			gamer._turn = false;
            for (int i = 0; i < nb_client*(gamer._stat["Magasin"]); ++i)
            {

                if (aleatoire.Next(0, 101) < attractive)
                {
                    key = aleatoire.Next(0, gamer._items.Count);
					if (gamer._items[key] != "NaN")
					{
                    	(int Quantity, double price, bool possible, double quali, int tour) = gamer._marchandise[gamer._items[key]];
						if (Quantity > 0)
						{
                    		gamer._marchandise[gamer._items[key]] = (--Quantity, price, possible, quali, tour);
							RemovePerime(gamer, key);
							if (gamer.promo)
								gamer.sum += price*0.8 + 0.1*price*(quali-1);
							else
                    			gamer.sum += price + 0.1*price*(quali-1);
						}
					}
                }
            }
			if (TourCount.TurnValues % 4 == 0)
          	{
				  (double benef, double attract, double chance) =
					evenement._event[evenement._eventComing[TourCount.TurnValues/4 - 1]];
				 gamer._stat["Attractivité"] *= attract;
				 gamer.sum *= benef;
          	}

			for (int i = 0; i < 12; ++i)
				Perime(gamer, i);
			Debug.Log(Gamer2.sum);
			gamer.AddMoney(gamer.sum);
			gamer._mounth += gamer.sum;

			bool b = false;
			if (TourCount.TurnValues % 4 == 0)
			{
				if (gamer._mounth < 4000)
					gamer._mounth = 4000;

					b = (!gamer.AddMoney(-gamer._mounth/4) || !gamer.AddMoney(-gamer._stat["Employé"]*gamer._stat["Salaire"]));
					if (b)
					{
						GameOver.SetActive(true);
					}
					else
					{
						gamer._mounth = 0;
					}
			}
			end = true;
			if (Gamer1._turn ==  Gamer2._turn)
			{
				Gamer1.TimeLeft = 124*Gamer1.nbCount;

					TourCount.AddTurn("");
				Gamer1._turn = true;
				Gamer2._turn = true;
				Gamer1._button = true;
				Gamer2._button = true;
				Vente1 = Gamer1.sum;
				Vente2 = Gamer2.sum;
				Gamer1.sum = 0;
				Gamer2.sum = 0;
				end = false;
				FinDeTour.SetActive(true);
				FinTour.Play();
				if (!(TourCount.TurnValues > TourCount.MaxTurn))
					AI.Act10();
			}
			if (TourCount.TurnValues > TourCount.MaxTurn || b)
			{
				Player1Script.move = false;
				GameOver.SetActive(true);
			}
        }
    }
	 IEnumerator attend()
    {
        yield return new WaitForSeconds(1000);
    }
	public void Perime(PlayerClass gamer, int key)
	{
		if (gamer._items[key] != "NaN")
		{
            (int Quantity, double price, bool possible, double promo, int tour) = gamer._marchandise[gamer._items[key]];
			int j = 0;
			switch (key)
			{
				case 0:
				  	gamer.Perime1.Add(gamer.More1);
				  	if (gamer.Perime1.Count > tour)
					{
						j = gamer.Perime1[0];
						gamer.Perime1.RemoveAt(0);
					}
					gamer.More1 = 0;
				  	break;
				case 1:
					gamer.Perime2.Add(gamer.More2);
				  	if (gamer.Perime2.Count > tour)
					{
						j = gamer.Perime2[0];
						gamer.Perime2.RemoveAt(0);
					}
					gamer.More2 = 0;
					break;
				case 2:
					gamer.Perime3.Add(gamer.More3);
				  	if (gamer.Perime3.Count > tour)
					{
						j = gamer.Perime3[0];
						gamer.Perime3.RemoveAt(0);
					}
					gamer.More3 = 0;
					break;
				case 3:
					gamer.Perime4.Add(gamer.More4);
				  	if (gamer.Perime4.Count > tour)
					{
						j = gamer.Perime4[0];
						gamer.Perime4.RemoveAt(0);
					}
					gamer.More4 = 0;
					break;
				case 4:
					gamer.Perime5.Add(gamer.More5);
				  	if (gamer.Perime5.Count > tour)
					{
						j = gamer.Perime5[0];
						gamer.Perime5.RemoveAt(0);
					}
					gamer.More5 = 0;
					break;
				case 5:
					gamer.Perime6.Add(gamer.More6);
				  	if (gamer.Perime6.Count > tour)
					{
						j = gamer.Perime6[0];
						gamer.Perime6.RemoveAt(0);
					}
					gamer.More6 = 0;
					break;
				case 6:
					gamer.Perime7.Add(gamer.More7);
				  	if (gamer.Perime7.Count > tour)
					{
						j = gamer.Perime7[0];
						gamer.Perime7.RemoveAt(0);
					}
					gamer.More7 = 0;
					break;
				case 7:
					gamer.Perime8.Add(gamer.More8);
				  	if (gamer.Perime8.Count > tour)
					{
						j = gamer.Perime8[0];
						gamer.Perime8.RemoveAt(0);
					}
					gamer.More8 = 0;
					break;
				case 8:
					gamer.Perime9.Add(gamer.More9);
				  	if (gamer.Perime9.Count > tour)
					{
						j = gamer.Perime9[0];
						gamer.Perime9.RemoveAt(0);
					}
					gamer.More9 = 0;
					break;
				case 9:
					gamer.Perime10.Add(gamer.More10);
				  	if (gamer.Perime10.Count > tour)
					{
						j = gamer.Perime10[0];
						gamer.Perime10.RemoveAt(0);
					}
					gamer.More10 = 0;
					break;
				case 10:
					gamer.Perime11.Add(gamer.More11);
				  	if (gamer.Perime11.Count > tour)
					{
						j = gamer.Perime11[0];
						gamer.Perime11.RemoveAt(0);
					}
					gamer.More11 = 0;
					break;
				case 11:
				  	gamer.Perime12.Add(gamer.More12);
				  	if (gamer.Perime12.Count > tour)
					{
						j = gamer.Perime12[0];
						gamer.Perime12.RemoveAt(0);
					}
					gamer.More12 = 0;
					break;
			}
			Quantity -= j;
			if (Quantity < 0)
				Quantity = 0;
			gamer._marchandise[gamer._items[key]] = (Quantity, price, possible, promo, tour);
		
		}
	}
  
   public void RemovePerime(PlayerClass gamer, int key)
   {
		switch (key)
		{
			case 0:
				if (gamer.Perime1.Count != 0 && gamer.Perime1[0] != 0)
					{
							
							--gamer.Perime1[0];
				
					}
				else if (gamer.Perime1.Count == 0)
					return;
				else
				{
			
						gamer.Perime1.RemoveAt(0);
					RemovePerime(gamer, key);
		
				}
				break;
			case 1:
				if (gamer.Perime2.Count != 0 && gamer.Perime2[0] != 0)
					{
				
							--gamer.Perime2[0];
							
					}

				else if (gamer.Perime2.Count == 0)
					return;
				else
				{
				
						gamer.Perime2.RemoveAt(0);
					RemovePerime(gamer, key);
					
				}
				break;
			case 2:
				if (gamer.Perime3.Count != 0 && gamer.Perime3[0] != 0)
					{
					
							--gamer.Perime3[0];
						
					}
				else if (gamer.Perime3.Count == 0)
					return;
				else
				{
						
						gamer.Perime3.RemoveAt(0);
					RemovePerime(gamer, key);
					
				}
				break;
			case 3:
				if (gamer.Perime4.Count != 0 && gamer.Perime4[0] != 0)
					{
					
							--gamer.Perime4[0];
							
					}
				else if (gamer.Perime4.Count == 0)
					return;
				else
				{
			
						gamer.Perime4.RemoveAt(0);
					RemovePerime(gamer, key);
				
				}
				break;
			case 4:
				if (gamer.Perime5.Count != 0 && gamer.Perime5[0] != 0)
					{
		
							--gamer.Perime5[0];
				
					}
				else if (gamer.Perime5.Count == 0)
					return;
				else
				{
					
						gamer.Perime5.RemoveAt(0);
					RemovePerime(gamer, key);
					
				}
				break;
			case 5:
				if (gamer.Perime6.Count != 0 && gamer.Perime6[0] != 0)
					{
					
							--gamer.Perime6[0];
						
					}
				else if (gamer.Perime6.Count == 0)
					return;
				else
				{
				
						gamer.Perime6.RemoveAt(0);
					RemovePerime(gamer, key);
			
				}
				break;
			case 6:
				if (gamer.Perime7.Count != 0 && gamer.Perime7[0] != 0)
					{
				
							--gamer.Perime7[0];
							
					}
				else if (gamer.Perime7.Count == 0)
					return;
				else
				{
					
						gamer.Perime7.RemoveAt(0);
					RemovePerime(gamer, key);
				
				}
				break;
			case 7:
				if (gamer.Perime8.Count != 0 && gamer.Perime8[0] != 0)
					{
				
							--gamer.Perime8[0];
					
					}
				else if (gamer.Perime8.Count == 0)
					return;
				else
				{
				
						gamer.Perime8.RemoveAt(0);
					RemovePerime(gamer, key);
					
				}
				break;
			case 8:
				if (gamer.Perime9.Count != 0 && gamer.Perime9[0] != 0)
					{
						
							--gamer.Perime9[0];
						
					}
				else if (gamer.Perime9.Count == 0)
					return;
				else
				{
					
						gamer.Perime9.RemoveAt(0);
					RemovePerime(gamer, key);
				
				}
				break;
			case 9:
				if (gamer.Perime10.Count != 0 && gamer.Perime10[0] != 0)
					{
						
							--gamer.Perime10[0];
			
					}
				else if (gamer.Perime10.Count == 0)
					return;
				else
				{
					
						gamer.Perime10.RemoveAt(0);
					RemovePerime(gamer, key);
				
				}
				break;
			case 10:
				if (gamer.Perime11.Count != 0 && gamer.Perime11[0] != 0)
				{
		
						--gamer.Perime11[0];
				
				}
				else if (gamer.Perime11.Count == 0)
					return;
				else
				{
				
						gamer.Perime11.RemoveAt(0);
					RemovePerime(gamer, key);
					
				}
				break;
			case 11:
				if (gamer.Perime12.Count != 0 && gamer.Perime12[0] != 0)
				{
					
					--gamer.Perime12[0];
							
				}
				else if (gamer.Perime12.Count == 0)
					return;
				else
				{
				
						gamer.Perime12.RemoveAt(0);
					RemovePerime(gamer, key);
					
				}
				break;
		}
   }
   
}
