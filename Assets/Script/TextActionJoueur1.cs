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
using Mirror;
using static FinDeTour;

public class TextActionJoueur1 : NetworkBehaviour
{
	public static Text action;
	public AudioSource audio;
	public AudioSource FinTour;
	public GameObject Text_action;
	public bool end;
	[SerializeField] private GameObject GameOver;
	[SerializeField] private GameObject Faillite;
	[SerializeField] private GameObject FinDeTour;
	[SerializeField] private GameObject ElementTour;
	[SerializeField] private GameObject Compteur1;
	[SerializeField] private GameObject Compteur2;
	public static double Vente1;
    public static double Vente2;
	public static double TotalVente1;
	public static double TotalVente2;
	public static double diff1;
	public static double diff2;
	public static int Quantity1;
	public static int Quantity2;
	public static double NbSalaire1;
	public static double NbSalaire2;
	public static double Collision;
	public static bool multi;
	public static bool faill1;
	public static bool faill2;
	
    // Start is called before the first frame update
    void Start()
    {
		action = GetComponent<Text>();
		audio = GetComponent<AudioSource>();
		FinTour = GetComponent<AudioSource>();
		end = false;
		Vente1 = 0;
		Vente2 = 0;
		diff1 = 0;
		diff2 = 0;
		faill1 = false;
		faill2 = false;
		Quantity1 = 0;
		Quantity2 = 0;
		TotalVente1 = 0;
		TotalVente2 = 0;
		NbSalaire1 = 0;
		NbSalaire2 = 0;
		multi = NetworkServer.connections.Count == 2;
    }
	IEnumerator pause()
	{
		CalCulus(true);
		yield return new WaitForSeconds(0.5f);
		CalCulus(false);
		yield return new WaitForSeconds(0.5f);
		up();
		
	}
	[ClientRpc]
	public void up()
	{
		Gamer1._turn = true;
		Gamer2._turn = true;
		Gamer1._button = true;
		Gamer2._button = true;
	}
    // Update is called once per frame
    void Update()
    {	
		double x = Text_action.transform.position.x;
		double x2 = Screen.width/2;
		if (faill1 || faill2)
		{
			ElementTour.SetActive(false);
			Faillite.SetActive(true);
			FinDeTour.SetActive(false);
			Compteur1.SetActive(false);
			Compteur2.SetActive(false);
			Gamer1.TimeLeft = 130;
		}
		if (multi && NetworkServer.connections.Count == 1)
		{
			multi = false;
			AI = new IntelligenceArtificielle();
		}
		if (FinDeTour.activeSelf && Gamer1.TimeLeft < 120)
		{
			FinDeTour.SetActive(false);
			Compteur1.SetActive(true);
			Compteur2.SetActive(true);
		}
			PlayerClass gamer;
			if (NetworkServer.active)
				gamer = Gamer1;
			else
				gamer = Gamer2;
			Player1Script.move = action.text == "" && gamer._button && !PlayerScript.pause && !FinDeTour.activeSelf && !Faillite.activeSelf && !GameOver.activeSelf;
			if (Gamer1.TimeLeft <= 0 && NetworkServer.active)
            {
				action.text = "";
                if (Gamer1._button && Gamer2._button)
                {
					
					/*
					bool verif2 = GameOver.activeSelf;
					double money = Gamer1._money;
					double res_Vente1 = Vente1;
					double res_TotalVente1 = TotalVente1;
					double sum2 = 0;
					double res_diff1 = diff1;
					double last_money = Gamer1._money;
					int res_Quantity1 = Quantity1;
			
					int last_quantite = Gamer1.quantite;
			
					double last_attrat = Gamer1._stat["Attractivité"];
					if(NetworkServer.connections.Count == 2)
						calcul(true, res_Vente1, res_TotalVente1, sum2, res_diff1, last_money, res_Quantity1, last_quantite, last_attrat, money, verif2);
					*/
					StartCoroutine("pause");
					
							
					/*
					verif2 = GameOver.activeSelf;
					money = Gamer2._money;
					res_Vente1 = Vente2;
					res_TotalVente1 = TotalVente2;
					sum2 = 0;
					res_diff1 = diff2;
					last_money = Gamer2._money;
					res_Quantity1 = Quantity2;
			
					last_quantite = Gamer2.quantite;
			
					last_attrat = Gamer2._stat["Attractivité"];
					if(NetworkServer.connections.Count == 2)
						calcul(false, res_Vente1, res_TotalVente1, sum2, res_diff1, last_money, res_Quantity1, last_quantite, last_attrat, money, verif2);
					*/
			
                }
                else if (Gamer2._button)
                {
						CalCulus(false);
						/*
						bool verif2 = GameOver.activeSelf;
						double money = Gamer2._money;
						double res_Vente1 = Vente2;
						double res_TotalVente1 = TotalVente2;
						double sum2 = 0;
						double res_diff1 = diff2;
						double last_money = Gamer2._money;
						int res_Quantity1 = Quantity2;
			
						int last_quantite = Gamer2.quantite;
			
						double last_attrat = Gamer2._stat["Attractivité"];
						if(NetworkServer.connections.Count == 2)
							calcul(false, res_Vente1, res_TotalVente1, sum2, res_diff1, last_money, res_Quantity1, last_quantite, last_attrat, money, verif2);
							*/
                }
                else
                {
					CalCulus(true);
					/*
					bool verif2 = GameOver.activeSelf;
					double money = Gamer1._money;
					double res_Vente1 = Vente1;
					double res_TotalVente1 = TotalVente1;
					double sum2 = 0;
					double res_diff1 = diff1;
					double last_money = Gamer1._money;
					int res_Quantity1 = Quantity1;
			
					int last_quantite = Gamer1.quantite;
			
					double last_attrat = Gamer1._stat["Attractivité"];
					if(NetworkServer.connections.Count == 2)
						calcul(true, res_Vente1, res_TotalVente1, sum2, res_diff1, last_money, res_Quantity1, last_quantite, last_attrat, money, verif2);
						*/
                }
				musique();
            }
			if (action.text.Length != 0)
				ChangementText(Player1Script.act, NetworkServer.active);
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
				}
				 MoreMaterielAOpponent(2);
				Player1Script.move = true;
				action.text = "";
			}
			else if (action.text == gamer._missingitems[Player1Script.act%6] + " : 300 $" && Input.GetKeyDown(KeyCode.Return))
			{
				string s = gamer._missingitems[Player1Script.act%6];
				if (action.color == Color.green)
				{
					MoreMaterielGOpponent(Player1Script.act+1, s);
					gamer._items[act] = s;
					audio.Play();
					int a = 0;
					double b = 0;
					bool c = false;
					double d = 0;
					int e = 0;
					(a, b, c, d, e) = gamer._marchandise[s];
					action.text = "Quantité de " + gamer._items[act] + $" : {a}";
				}
			}
			else if (action.text.Contains("Quantité"))
			{
				string item = gamer._items[Player1Script.act];
				if (Input.GetKeyDown(KeyCode.Return))
				{
					MoreAproOpponent(item, Player1Script.act);
					if (action.color == Color.green)
					{
						audio.Play();
					}
				}
				(int n, double j, bool b, double d, int k)= gamer._marchandise[item];
				if (j*5>gamer._money)
						action.color = Color.red;
				else 
						action.color = Color.green;
				action.text = "Quantité de " + item + $" : {n}";
			}
			else if (action.text.Contains("Prix de"))
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
				action.color = Color.green;
				action.text = "< Prix de " + item + $" : {Round(j,2)} $ >";
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
					action.color = Color.red;
				else 
					action.color = Color.green;
				
			}
			else if (action.text.Contains("employés"))
			{
				if (gamer._money < 700 || gamer._stat["Employé"] <= 0)
					action.color = Color.red;
				else
					action.color = Color.green;
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
				action.text = $"< Nombre d'employés : {gamer._stat["Employé"]} >";
			}
			else if (action.text.Contains("Salaire"))
			{
				if (gamer._stat["Salaire"] == 1399)
					action.color = Color.red;
				else
					action.color = Color.green;
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
				action.text = $"< Salaire : {gamer._stat["Salaire"]} $ >";
			}
			else if (action.text.Contains("magasins"))
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
					double mag = gamer._stat["Magasin"];
					magasinOpponent(true);
					if (mag != gamer._stat["Magasin"])
						audio.Play();
				}
				action.text = $"< Nombre de magasins : {gamer._stat["Magasin"]} >";
			}
			else if (action.text.Contains("Prime"))
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
			else if (action.text.Contains("romotion"))
			{
				if (gamer.materiel[0] != "acheté")
				{
					if (gamer._money < 300)
						action.color = Color.red;
					else
						action.color = Color.green;
					if (action.color == Color.green && Input.GetKeyDown(KeyCode.Return))
					{
						PromoOpponent();
					
						action.text = "Promotion en attente";
						audio.Play();
					}
				}
				else
				{
					action.color = Color.green;
					if (Input.GetKeyDown(KeyCode.Return))
					{
						PromoOpponent();
						audio.Play();
					}
					if (gamer.promo)
						action.text = "Promotion en cours";
					else
						action.text = "Promotion en attente";
				}
			}
			else if (action.text.Contains("Cartes"))
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
			else if (action.text.Contains("Cadeaux"))
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
			else if (action.text.Contains("Publicité"))
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
			else if (action.text.Contains("Finir"))
			{
				if (Input.GetKeyDown(KeyCode.Return))
				{
					OpponentCalcul();
					FinTour.Play();
					action.text = "";
					//Player1Script.move = !end;
				}
			}
			else
			{
				ChangementText(Player1Script.act, NetworkServer.active);
			}
	
	
	}

	private void musique()
	{
		if (NetworkServer.active)
			PlayServer();
		else
			PlayClient();
	}

	[Command(requiresAuthority = false)]
	private void PlayClient() => PlayServer();

	[ClientRpc]
	private void PlayServer() => FinTour.Play();

	public  void ChangementText(int n, bool verif)
    {
        PlayerClass gamer;
        if (verif)
            gamer = Gamer1;
        else
            gamer = Gamer2;
		if ((TextActionJoueur1.action.text.Contains("Finir") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("magasins") && Input.GetKeyDown(KeyCode.UpArrow)))
            TextActionJoueur1.action.text = $"< Salaire : {gamer._stat["Salaire"]} $ >";
        else if ((TextActionJoueur1.action.text.Contains("Salaire") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Prime") && Input.GetKeyDown(KeyCode.UpArrow)))
            TextActionJoueur1.action.text = $"< Nombre de magasins : {gamer._stat["Magasin"]} >";
        else if ((TextActionJoueur1.action.text.Contains("magasins") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("employés :") && Input.GetKeyDown(KeyCode.UpArrow)))
            TextActionJoueur1.action.text = "Prime : 1000 $/employé";
        else if ((TextActionJoueur1.action.text.Contains("Publicité") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Cadeaux") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Cartes de fidélité : 100 $";
        }
        else if ((TextActionJoueur1.action.text.Contains("Cartes") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Publicité") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Cadeaux : 500 $";
        }
        else if ((TextActionJoueur1.action.text.Contains("Cadeaux") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Cartes") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Publicité : 1000 $";
        }
        else if ((TextActionJoueur1.action.text.Contains("Prime") && Input.GetKeyDown(KeyCode.DownArrow)) ||(TextActionJoueur1.action.text.Contains("Finir") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = $"< Nombre d'employés : {gamer._stat["Employé"]} >";
            TextActionJoueur1.action.color = Color.green;
        }
            else if ((TextActionJoueur1.action.text.Contains("employés :") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Salaire") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Finir son tour";
                TextActionJoueur1.action.color = Color.green;
            }
        else if (gamer._items[n] != "NaN")
        {
            (int m, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[n]];
            if ((TextActionJoueur1.action.text.Contains("Quantité de") 
                && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("de niveau") && Input.GetKeyDown(KeyCode.UpArrow)))
                    TextActionJoueur1.action.text = "< Prix de " + gamer._items[n] + $" : {j} $ >";
            else if ((TextActionJoueur1.action.text.Contains("Prix de") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Quantité de") && Input.GetKeyDown(KeyCode.UpArrow)))
                TextActionJoueur1.action.text = gamer._items[n] + " de niveau " +$"{d}"+$" : {50*Math.Pow(d, 2)} $";
            else if (
            (TextActionJoueur1.action.text.Contains("de niveau") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Prix de") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[n] + $" : {m}";

            }
        }
            
    }

	public void MoreMaterielAOpponent(int p)
	{
		if (NetworkServer.active)
		{
			AMateriel(p, true);
		}
		else
		{
			OpponentMaterielAServerRpC(p);
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentMaterielAServerRpC(int p) => AMateriel(p, false);

   [ClientRpc]
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
		if (NetworkServer.active)
		{
			MaterielG(p, s, true);
		}
		else
		{
			OpponentMaterielGServerRpC(p, s);
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentMaterielGServerRpC(int p, string s) => MaterielG(p, s, false);

	[ClientRpc]
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
		
		}
		else
		{
			Player1Script.move = true;
		}
	}

	public void MoreAproOpponent(string item, int el)
	{
		if (NetworkServer.active)
		{
			MoreApro(item, true, el);
		}
		else
		{
			OpponentAproServerRpC(item, el);
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentAproServerRpC(string item, int el) => MoreApro(item, false, el);

	[ClientRpc]
	public void MoreApro(string item, bool joueur, int el)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		(int i, double j, bool b, double d, int k)= gamer._marchandise[item];
		if (b && gamer.AddMoney(-gamer.prix[el]*5))
		{
			gamer._marchandise[item] = (i+5, j, b, d, k);
			switch (el+1)
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
		if (NetworkServer.active)
		{
			MorePrice(item, true);
		}
		else
		{
			OpponentMPriceServerRpC(item);
		}
	}
	[Command(requiresAuthority = false)]
	private void OpponentMPriceServerRpC(string item) => MorePrice(item, false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			LessPrice(item, true);
		}
		else
		{
			OpponentLPriceServerRpC(item);
		}
	}


	[Command(requiresAuthority = false)]
	private void OpponentLPriceServerRpC(string item) => LessPrice(item, false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			MoreQuali(item, true);
		}
		else
		{
			OpponentQualiServerRpC(item);
		}
	}
	[Command(requiresAuthority = false)]
	private void OpponentQualiServerRpC(string item) => MoreQuali(item, false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			Employe(verif, true);
		}
		else
		{
			OpponentEmployeServerRpC(verif);
		}
	}
	[Command(requiresAuthority = false)]
	private void OpponentEmployeServerRpC(bool verif) => Employe(verif, false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			Salaire(verif, true);
		}
		else
		{
			OpponentsalaireServerRpC(verif);
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentsalaireServerRpC(bool verif) => Salaire(verif, false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			Magasin(verif, true);
		}
		else
		{
			OpponentmagasinServerRpC(verif);
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentmagasinServerRpC(bool verif) => Magasin(verif, false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			Prime(true);
		}
		else
		{
			OpponentprimeServerRpC();
		}
	}
	[Command(requiresAuthority = false)]
	private void OpponentprimeServerRpC() => Prime(false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			Promotion(true);
		}
		else
		{
			OpponentPromoServerRpC();
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentPromoServerRpC() => Promotion(false);

	[ClientRpc]
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
		if (NetworkServer.active)
		{
			Carte(true);
		}
		else
		{
			OpponentcarteServerRpC();
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentcarteServerRpC() => Carte(false);

	[ClientRpc]
	public void Carte(bool joueur)
    {
		PlayerClass gamer;
		PlayerClass gamer2;
		if (joueur)
		{
			gamer = Gamer1;
			gamer2 = Gamer2;
		}
		else
		{
			gamer = Gamer2;
			gamer2 = Gamer1;
		}
		if(gamer.AddMoney(-100))
		{
			gamer._stat["Attractivité"] += 0.5;
			if (gamer2._stat["Attractivité"] >= 1.5)
				gamer2._stat["Attractivité"] -= 0.5;
			else if(gamer2._stat["Attractivité"] >= 1)
				gamer2._stat["Attractivité"] = 1;
				
		}
    }


	public void cadeauOpponent()
	{
		if (NetworkServer.active)
		{
			Carte(true);
		}
		else
		{
			OpponentcadeauServerRpC();
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentcadeauServerRpC() => Carte(false);

	[ClientRpc]
	public void Cadeau(bool joueur)
    {
		PlayerClass gamer;
		PlayerClass gamer2;
		if (joueur)
		{
			gamer = Gamer1;
			gamer2 = Gamer2;
		}
		else
		{
			gamer = Gamer2;
			gamer2 = Gamer1;
		}
		if( gamer.AddMoney(-500))
		{
			gamer._stat["Attractivité"] += 2.5;
			if(gamer2._stat["Attractivité"] >= 3.5)
				gamer2._stat["Attractivité"] -= 2.5;
			else if(gamer2._stat["Attractivité"] >= 1)
				gamer2._stat["Attractivité"] = 1;
		}
    }


	public void pubOpponent()
	{
		if (NetworkServer.active)
		{
			Pub(true);
		}
		else
		{
			OpponentPubServerRpC();
		}
	}

	[Command(requiresAuthority = false)]
	private void OpponentPubServerRpC() => Pub(false);

	[ClientRpc]
	public void Pub(bool joueur)
    {
		PlayerClass gamer;
		PlayerClass gamer2;
		if (joueur)
		{
			gamer = Gamer1;
			gamer2 = Gamer2;
		}
		else
		{
			gamer = Gamer2;
			gamer2 = Gamer1;
		}
		if(gamer.AddMoney(-1000))
		{
			gamer._stat["Attractivité"] += 5;
			if(gamer2._stat["Attractivité"] >= 6)
				gamer2._stat["Attractivité"] -= 5;
			else if(gamer2._stat["Attractivité"] >= 1)
				gamer2._stat["Attractivité"] = 1;
		}
    }

	public void OpponentCalcul()
	{
			CalCulus(NetworkServer.active);

		/*
		bool verif2 = GameOver.activeSelf;
		if (NetworkServer.active)
		{
				CalCulus(true);
				double money = Gamer1._money;
				double res_Vente1 = Vente1;
				double res_TotalVente1 = TotalVente1;
				double sum = 0;
				double res_diff1 = diff1;
				double last_money = Gamer1._money;
				int res_Quantity1 = Quantity1;
			
				int last_quantite = Gamer1.quantite;
			
				double last_attrat = Gamer1._stat["Attractivité"];
				if(NetworkServer.connections.Count == 2)
					calcul(true, res_Vente1, res_TotalVente1, sum, res_diff1, last_money, res_Quantity1, last_quantite, last_attrat, money, verif2);
				foreach (string s in Gamer1._marchandise.Keys)
				{
					(int j, double d, bool b, double st, int l) = Gamer1._marchandise[s];
					MAJQuantity(true, s, j);
				}
			
		}
		else
		{
				OpponentCalculServerRpC(verif2);
				
		}
		*/
	}
	[ClientRpc]
	public void MAJQuantity(bool verif,string s, int q)
	{
		PlayerClass gamer;
		if(verif)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		(int j, double d, bool b, double st, int l) = gamer._marchandise[s];
		gamer._marchandise[s] = (q, d, b, st, l);
	}
	[Command(requiresAuthority = false)]
	public void OpponentCalculServerRpC(bool verif2)
	{
		CalCulus(false);
		double money = Gamer2._money;
		double res_Vente1 = Vente2;
		double res_TotalVente1 = TotalVente2;
		double sum = 0;
		double res_diff1 = diff2;
		double last_money = Gamer2._money;
		int res_Quantity1 = Quantity2;
		int last_quantite = Gamer2.quantite;
			
		double last_attrat = Gamer2._stat["Attractivité"];
		calcul(false, res_Vente1, res_TotalVente1, sum, res_diff1, last_money, res_Quantity1, last_quantite, last_attrat, money, verif2);
		foreach (string s in Gamer2._marchandise.Keys)
		{
			(int j, double d, bool b, double st, int l) = Gamer2._marchandise[s];
			MAJQuantity(false, s, j);
		}
	}

   	[ClientRpc]
	public void calcul(bool verif, double v1, double tv1, double sum, double diff, double lm, int quantity, int lq, double lsq, double money, bool verif2)
	{
		if(verif)
		{
			Gamer1._money = money;
			Vente1 = v1;
			TotalVente1 += tv1;
			Gamer1.sum = sum;
			diff1 = diff;
			Gamer1.last_money = lm;
			Quantity1 = quantity;
			
			Gamer1.last_quantite = lq;
			
			Gamer1.last_attrat = lsq;
			if(Gamer2._turn)
			{
				Gamer1._turn = false;
				Gamer1._button = false;
			}
			else
			{
				Gamer1._turn = true;
				Gamer1._button = true;
				Gamer2._turn = true;
				Gamer2._button = true;
			}
		}
		else
		{
			Gamer2._money = money;
			Vente2 = v1;
			TotalVente2 += tv1;
			Gamer2.sum = sum;
			diff2 = diff;
			Gamer2.last_money = lm;
			Quantity2 = quantity;
			
			Gamer2.last_quantite = lq;
			
			Gamer2.last_attrat = lsq;
			if(Gamer1._turn)
			{
				Gamer2._turn = false;
				Gamer2._button = false;
			}
			else
			{
				Gamer1._turn = true;
				Gamer1._button = true;
				Gamer2._turn = true;
				Gamer2._button = true;
			}
		}
		if (Gamer1._turn && Gamer2._turn)
		{
			Gamer1.TimeLeft = 130*Gamer1.nbCount;
			TourCount.AddTurn("");
			Compteur1.SetActive(false);
			Compteur2.SetActive(false);
			if (TourCount.TurnValues <= TourCount.MaxTurn)
			{
				FinDeTour.SetActive(true);
			}
			if (!(TourCount.TurnValues > TourCount.MaxTurn) && NetworkServer.connections.Count == 1)
					AI.Act10();
		}
		if(verif2)
		{
			Player1Script.move = false;
			ElementTour.SetActive(false);
			GameOver.SetActive(true);
			FinDeTour.SetActive(false);
			Compteur1.SetActive(false);
			Compteur2.SetActive(false);
		}
	}
	[Command(requiresAuthority = false)]
	public void ImpactEvenementCommand() => ImpactEvenementClient(false);
	[ClientRpc]
	public void  ImpactEvenementClient(bool joueur)
	{
		PlayerClass gamer;
		if(joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		(double benef, double attract, double chance) =
					evenement._event[evenement._eventComing[TourCount.TurnValues/4 - 1]];
				 gamer._stat["Attractivité"] *= attract;
				 gamer.sum *= benef;
	}

	[Command(requiresAuthority = false)]
	public void AchatProduitCommand(int key) => AchatProduitClient(false, key);

	[ClientRpc]
	public void AchatProduitClient(bool joueur, int key)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		(int Quantity, double price, bool possible, double quali, int tour) = gamer._marchandise[gamer._items[key]];
		gamer._marchandise[gamer._items[key]] = (--Quantity, price, possible, quali, tour);
		++gamer.quantite;
		RemovePerime(gamer, key);
		if (gamer.promo)
			gamer.sum += price*0.8 + 0.1*price*(quali-1);
		else
			gamer.sum += price + 0.1*price*(quali-1);
	}
	[Command(requiresAuthority = false)]
	public void TurnClient() => Turn(false);

	[ClientRpc]
	public void Turn(bool verif)
	{
		if (verif)
		{
			Gamer1._turn = false;
			Gamer1._button = false;
		}
		else
		{
			Gamer2._turn = false;
			Gamer2._button = false;
		}
	}
	[Command(requiresAuthority = false)]
	public void FinaliteCommand() => Finalite(false);

	[ClientRpc]
	public void Finalite(bool joueur)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer.sum *= (1+gamer._stat["Qualité"]/100);
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
					if (joueur)
						faill1 = true;
					else
						faill2 = true;
					ElementTour.SetActive(false);
					Faillite.SetActive(true);
					FinDeTour.SetActive(false);
					Compteur1.SetActive(false);
					Compteur2.SetActive(false);
					Gamer1.TimeLeft = 130;
				}
				else
				{
					gamer._mounth = 0;
				}
				if (gamer == Gamer1)
					NbSalaire1 += gamer._stat["Employé"];
				else
					NbSalaire2 += gamer._stat["Employé"];
		}
		if(Gamer1._turn ==  Gamer2._turn)
		{
			Gamer1.TimeLeft = 130*Gamer1.nbCount;
					
			Gamer2._turn = true;
			Gamer2._button = true;
			Vente2 = Gamer2.sum;
			TotalVente2 += Gamer2.sum;
			Gamer2.sum = 0;
			diff2 = Gamer2._money - Gamer2.last_money;
			Gamer2.last_money = Gamer2._money;
			Quantity2 = Gamer2.quantite - Gamer2.last_quantite;
			
			Gamer2.last_quantite = Gamer2.quantite;
			
			Gamer2.last_attrat = Gamer2._stat["Attractivité"];
			Gamer1._turn = true;
			Gamer1._button = true;
			Vente1 = Gamer1.sum;
			TotalVente1 += Gamer1.sum;
			Gamer1.sum = 0;
			diff1 = Gamer1._money - Gamer1.last_money;
			Gamer1.last_money = Gamer1._money;
			Quantity1 = Gamer1.quantite - Gamer1.last_quantite;
			
			Gamer1.last_quantite = Gamer1.quantite;
			
			Gamer1.last_attrat = Gamer1._stat["Attractivité"];
			FinTour.Play();
			TourCount.AddTurn("");
			Compteur1.SetActive(false);
			Compteur2.SetActive(false);
			if (TourCount.TurnValues <= TourCount.MaxTurn && !faill1 && !faill2)
			{
				FinDeTour.SetActive(true);
			}
			if (!(TourCount.TurnValues > TourCount.MaxTurn) && NetworkServer.connections.Count == 1)
				AI.Act10();
		}
		if (TourCount.TurnValues > TourCount.MaxTurn && !b  && !Faillite.activeSelf)
		{
			Player1Script.move = false;
			ElementTour.SetActive(false);
			GameOver.SetActive(true);
			FinDeTour.SetActive(false);
			Compteur1.SetActive(false);
			Compteur2.SetActive(false);
		}
	}
	public double CalCulus(bool verif)
    {
		PlayerClass gamer;
		if (verif)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        System.Random aleatoire = new System.Random();
        double attractive = gamer._stat["Attractivité"];
        double client = gamer._stat["Clientèle"];
        int nb_client = aleatoire.Next((int)Round(client / 2, 0), (int)Round(client * 2, 0));
        int key;
		double sum = 0;
		bool end = true;
        if (gamer._turn)
        {
			if(NetworkServer.active)
				Turn(verif);
			else
				TurnClient();
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
							if(NetworkServer.active)
								AchatProduitClient(verif, key);
							else
								AchatProduitCommand(key);
						}
					}
                }
            }
			if (TourCount.TurnValues % 4 == 0)
          	{
				  if(NetworkServer.active)
					ImpactEvenementClient(verif);
				  else
					ImpactEvenementCommand();
          	}

			for (int i = 0; i < 12; ++i)
			{
				if(NetworkServer.active)
					Perime(verif, i);
				else
					PerimeCommand(i);
			}
			if(NetworkServer.active)
				Finalite(verif);
			else
				FinaliteCommand();
        }
		return sum;
    }
	 IEnumerator attend()
    {
        yield return new WaitForSeconds(1000);
    }
	[Command(requiresAuthority = false)]
	public void PerimeCommand(int key) => Perime(false, key);

	[ClientRpc]
	public void Perime(bool joueur, int key)
	{
		PlayerClass gamer;
		if (joueur)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer._turn = false;
		gamer._button = false;
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
