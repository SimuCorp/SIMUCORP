using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static System.Math;
using static MoneyCount;
using static TourCount;
using static PlayerClass;
using static Player1Script;

public class PlayerScript : MonoBehaviour
{
	private bool verif;
    [SerializeField]
    private float speed = 0; //vitesse de déplacement
	[SerializeField] private GameObject Accueil;
	[SerializeField] private GameObject ChoixTour;
	[SerializeField] private GameObject Options;
	[SerializeField] private GameObject Apro1;
	[SerializeField] private GameObject Materiel1;
	[SerializeField] private GameObject Materiel2;
	[SerializeField] private GameObject Materiel3;
	[SerializeField] private GameObject Prix1;
	[SerializeField] private GameObject Commercial;
	[SerializeField] private GameObject Gestion;
	[SerializeField] private GameObject Quali1;
	[SerializeField] private GameObject RH;
	[SerializeField] private GameObject Difficulte;
	[SerializeField] private GameObject GameOver;
	[SerializeField] private GameObject NonPerissable;
	[SerializeField] private GameObject Perissable;
	[SerializeField] private GameObject Qualite;
	[SerializeField] private GameObject Son;
	[SerializeField] private GameObject ScenePrincipale;
	[SerializeField] private GameObject Primeur;
	[SerializeField] private GameObject Boucherie;
	[SerializeField] private GameObject Coiffeur;
	[SerializeField] private GameObject Poissonerie;
	[SerializeField] private GameObject Fleuriste;
	[SerializeField] private GameObject Librairie;
	[SerializeField] private GameObject Vetement;
	[SerializeField] private GameObject Bijouterie;
	[SerializeField] private GameObject InfoTour;
	[SerializeField] private GameObject InfoJoueur1;
	[SerializeField] private GameObject InfoJoueur2;
	[SerializeField] private GameObject Pause;
	public static float ButtonLeft = 1;
    public bool TimerOn = false;
    public Text Countdown;
	public int tour = 1;
	public bool access;
	public float time = 100;
	public static PlayerClass Gamer1 = new Primeur("Primeur");
	public static PlayerClass Gamer2 = new Boucherie("Boucher");
	public static IntelligenceArtificielle? AI;
	public static Evenement evenement = new Evenement();
	public int NbScene;
	public static bool pause = false;
    void Start()
    {
		verif = false;
        TimerOn = true;
        Countdown = GetComponent<Text> ();
		NbScene = 0;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        { 
			Primeur.SetActive(false);
			Librairie.SetActive(false);
			Coiffeur.SetActive(false);
			Poissonerie.SetActive(false);
			Bijouterie.SetActive(false);
			Vetement.SetActive(false);
			Fleuriste.SetActive(false);
			Boucherie.SetActive(false);
			NonPerissable.SetActive(false);
			Perissable.SetActive(false);
			Accueil.SetActive(false);
			Difficulte.SetActive(false);
			ChoixTour.SetActive(false);
			InfoTour.SetActive(false);
			InfoJoueur1.SetActive(false);
			InfoJoueur2.SetActive(false);
			Options.SetActive(true);
        }
		if (Input.GetKeyDown(KeyCode.Space) && Gamer1.ready && Gamer2.ready)
        { 
			InfoTour.SetActive(pause);
			pause = !pause;
			Pause.SetActive(pause);
			ChangementPause();
		}
		
    }

	public void ChangementPause()
	{
		
			Mouvement();
		
	}



	
	private void Mouvement() => Player1Script.move = pause;
	

	public void calcul()
	{
	
			if(Gamer1._button)
			{

				Gamer1._button = false;
				CalCulus(Gamer1);
				
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

	
    void UpdateTimer()
    {
        Countdown.text = $"{(int)(Gamer1.TimeLeft/Gamer1.nbCount)}";
    }

    public void UpdateTimeButton(PlayerClass gamer)
    {
        gamer._button = false;
        while (ButtonLeft > 0)
        {
            ButtonLeft -= Time.deltaTime;
            ButtonLeft -= 1;
        }
        ButtonLeft = 3;
        gamer._button = true;
    }

	public void ExitAccueil()
	{
	
			ExitAccueilAux();
		
		
	}

	public void ExitAccueilAux()
	{
		Accueil.SetActive(false);
		ChoixTour.SetActive(true);
	}

	public void LastScene()
	{
		Options.SetActive(false);
		if(Gamer1.ready && Gamer2.ready)
		{
			if (Gamer1._name == "Primeur")
				Primeur.SetActive(true);
			else if (Gamer1._name == "Libraire")
				Librairie.SetActive(true);
			else if (Gamer1._name == "Coiffeur")
				Coiffeur.SetActive(true);
			else if (Gamer1._name == "Poissonier")
				Poissonerie.SetActive(true);
			else if (Gamer1._name == "Bijoutier")
				Bijouterie.SetActive(true);
			else if (Gamer1._name == "Prêt à porter")
				Vetement.SetActive(true);
			else if (Gamer1._name == "Fleuriste")
				Fleuriste.SetActive(true);
			else
				Boucherie.SetActive(true);
			if (Gamer2._name == "Primeur")
				Primeur.SetActive(true);
			else if (Gamer2._name == "Libraire")
				Librairie.SetActive(true);
			else if (Gamer2._name == "Coiffeur")
				Coiffeur.SetActive(true);
			else if (Gamer2._name == "Poissonier")
				Poissonerie.SetActive(true);
			else if (Gamer2._name == "Bijoutier")
				Bijouterie.SetActive(true);
			else if (Gamer2._name == "Prêt à porter")
				Vetement.SetActive(true);
			else if (Gamer2._name == "Fleuriste")
				Fleuriste.SetActive(true);
			else
				Boucherie.SetActive(true);
			InfoTour.SetActive(true);
			InfoJoueur1.SetActive(true);
			InfoJoueur2.SetActive(true);
		}
		else
			Accueil.SetActive(true);
	}

	public void Exit()
    {
        RH.SetActive(false);
		Commercial.SetActive(false);
		Gestion.SetActive(false);
		ScenePrincipale.SetActive(true);
    }

	public void ExitGeneral()
	{
		Quali1.SetActive(false);
		Prix1.SetActive(false);
		Apro1.SetActive(false);
		Materiel1.SetActive(false);
		Materiel2.SetActive(false);
		Materiel3.SetActive(false);
		RH.SetActive(false);
		Commercial.SetActive(false);
		Gestion.SetActive(false);
		Options.SetActive(false);
		Qualite.SetActive(false);
		ScenePrincipale.SetActive(true);
	}

	public void ExitEnd()
	{
		Quali1.SetActive(false);
		Prix1.SetActive(false);
		Apro1.SetActive(false);
		Materiel1.SetActive(false);
		Materiel2.SetActive(false);
		Materiel3.SetActive(false);
		RH.SetActive(false);
		Commercial.SetActive(false);
		Gestion.SetActive(false);
		Options.SetActive(false);
		Qualite.SetActive(false);
		ScenePrincipale.SetActive(false);
		InfoTour.SetActive(false);
		GameOver.SetActive(true);
	}

    public void ExitGestion()
    {
		
			if(Gamer1.ready && Gamer1._button && Gamer2.ready)
			{
				ScenePrincipale.SetActive(false);
				Quali1.SetActive(false);
				Prix1.SetActive(false);
				Apro1.SetActive(false);
				Materiel1.SetActive(false);
				Materiel2.SetActive(false);
				Materiel3.SetActive(false);
				Gestion.SetActive(true);
			}
		
		else if (Gamer2.ready && Gamer1.ready && Gamer2._button)
		{
			ScenePrincipale.SetActive(false);
			Quali1.SetActive(false);
			Prix1.SetActive(false);
			Apro1.SetActive(false);
			Materiel1.SetActive(false);
			Materiel2.SetActive(false);
			Materiel3.SetActive(false);
			Gestion.SetActive(true);
		}
    }

	public void ExitCommercial()
    {
	
			if (Gamer1.ready && Gamer1._button && Gamer2.ready)
			{
				ScenePrincipale.SetActive(false);
				Commercial.SetActive(true);
			}
		
		else if (Gamer2.ready && Gamer2._button && Gamer1.ready)
		{
				ScenePrincipale.SetActive(false);
				Commercial.SetActive(true);
		}
    }
	public void ExitRH()
    {
	
		
			if (Gamer1.ready && Gamer1._button && Gamer2.ready)
			{
        		ScenePrincipale.SetActive(false);
				RH.SetActive(true);
			}
	
		else if (Gamer2.ready && Gamer2._button && Gamer1.ready)
		{
			ScenePrincipale.SetActive(false);
			RH.SetActive(true);
		}
    }

	public void ExitPrix()
    {
        Gestion.SetActive(false);
		Prix1.SetActive(true);
		NbScene = 0;
		TextPrix1.n = 3*NbScene+1;
		TextPrix2.n = 3*NbScene+2;
		TextPrix3.n = 3*NbScene+3;
    }
	public void ExitPrix1()
    {
        NbScene = (NbScene+1)%4;
		TextPrix1.n = 3*NbScene+1;
		TextPrix2.n = 3*NbScene+2;
		TextPrix3.n = 3*NbScene+3;
    }

	public void ExitApro()
    {
        Gestion.SetActive(false);
		Apro1.SetActive(true);
		NbScene = 0;
		TextApro1.n = 3*NbScene+1;
		TextApro2.n = 3*NbScene+2;
		TextApro3.n = 3*NbScene+3;
    }
	public void ExitApro1()
	{
		NbScene = (NbScene+1)%4;
		TextApro1.n = 3*NbScene+1;
		TextApro2.n = 3*NbScene+2;
		TextApro3.n = 3*NbScene+3;
	}

	public void ExitQuali()
    {
        Gestion.SetActive(false);
		Quali1.SetActive(true);
		NbScene = 0;
		TextQuali1.n = NbScene*3 +1;
		TextQuali2.n = NbScene*3 +2;
		TextQuali3.n = NbScene*3 +3;
    }
	public void ExitQuali1()
	{
		NbScene = (NbScene+1)%4;
		TextQuali1.n = NbScene*3 +1;
		TextQuali2.n = NbScene*3 +2;
		TextQuali3.n = NbScene*3 +3;
	}

	public void ExitMateriel()
    {
        Gestion.SetActive(false);
		Materiel1.SetActive(true);
    }
	public void ExitMateriel1()
	{
		Materiel1.SetActive(false);
		Materiel2.SetActive(true);
	}

	public void ExitMateriel2()
	{
		Materiel2.SetActive(false);
		Materiel3.SetActive(true);
	}

	public void ExitMateriel3()
	{
		Materiel3.SetActive(false);
		Materiel1.SetActive(true);
	}
	
	public void Simple()
	{
	
			SimpleAux();
	}

	public void SimpleAux()
	{
		Difficulte.SetActive(false);
		NonPerissable.SetActive(true);
	}

	public void Difficile()
	{
	
			DifficileAux();
	}

	public void DifficileAux()
	{
		Difficulte.SetActive(false);
		Perissable.SetActive(true);
	}
	
	
	public void ChangementPrimeur()
	{
		
			ExitPrimeur(true);
		
	}
	
	public void ExitPrimeur(bool joueur)
	{
		verif = true;
		float taille = Screen.width;
		string s = "Primeur";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Primeur"))
		{
			Gamer1 = new Primeur("Primeur");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Boucherie("Boucher");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Boucherie.SetActive(true);
					Boucherie.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Primeur.SetActive(true);
			if (Gamer2.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Primeur"))
		{
			Gamer2 = new Primeur("Primeur");
			multijoueur = true;
			Gamer2.ready = true;
			TurnValues = 1;
			Primeur.SetActive(true);
			Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
			if (Gamer1.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}
		}
	}

	public void ChangementBoucherie()
	{
		
			ExitBoucherie(true);
		
	}

	public void ExitBoucherie(bool joueur)
	{
		verif = true;
		float taille = Screen.width;
		string s = "Boucher";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Boucher"))
		{
			Gamer1 = new Boucherie("Boucher");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Boucherie.SetActive(true);
			if (Gamer2.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Boucher"))
		{
			Gamer2 = new Boucherie("Boucher");
			Gamer2.ready = true;
			multijoueur = true;
			TurnValues = 1;
			Boucherie.SetActive(true);
			Boucherie.transform.Translate(new Vector3(taille/2, 0, 0));
			if (Gamer1.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}
		}

	}

	public void ChangementLibraire()
	{
		
			ExitLibraire(true);
		
	}
	
	public void ExitLibraire(bool joueur)
	{
		verif = true;
		float taille = Screen.width;
		string s = "Libraire";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Libraire"))
		{
			Gamer1 = new Libraire("Libraire");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Librairie.SetActive(true);
			Librairie.transform.Translate(new Vector3(-taille/2, 0, 0));
			if (Gamer2.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}


		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Libraire"))
		{
			Gamer2 = new Libraire("Libraire");
			Gamer2.ready = true;
			multijoueur = true;
			TurnValues = 1;
			Librairie.SetActive(true);
			if (Gamer2.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}


		}
	}

	public void ChangementCoiffeur()
	{
		
			ExitCoiffeur(true);
		
	}

	public void ExitCoiffeur(bool joueur)
	{
		verif = true;
		string s = "Coiffeur";
			float taille = Screen.width;
		if (joueur && (!Gamer2.ready || Gamer2._name != "Coiffeur"))
		{
			Gamer1 = new Coiffeur("Coiffeur");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Coiffeur.SetActive(true);
			Coiffeur.transform.Translate(new Vector3(-taille/2, 0, 0));
			if (Gamer2.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Coiffeur"))
		{
			Gamer2 = new Coiffeur("Coiffeur");
			multijoueur = true;
			Gamer2.ready = true;
			TurnValues = 1;
			Coiffeur.SetActive(true);
			if (Gamer1.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		}
	}

	public void ChangementPoisson()
	{
		
			ExitPoisson(true);
		
	}

	public void ExitPoisson(bool joueur)
	{
		verif = true;
		float taille = Screen.width;
		string s = "Poissonier";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Poissonier"))
		{
			Gamer1 = new Poissonier("Poissonier");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Poissonerie.SetActive(true);
			if (Gamer2.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}
	

		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Poissonier"))
		{
			Gamer2 = new Poissonier("Poissonier");
			multijoueur = true;
			Gamer2.ready = true;
			TurnValues = 1;
			Poissonerie.SetActive(true);
			Poissonerie.transform.Translate(new Vector3(taille/2, 0, 0));
			if (Gamer1.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}


		}
	}
	public void ChangementBijouterie()
	{
		
			ExitBijouterie(true);
		
	}
	
	public void ExitBijouterie(bool joueur)
	{
		verif = true;
		float taille = Screen.width;
		string s = "Bijoutier";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Bijoutier"))
		{
			Gamer1 = new Bijouterie("Bijoutier");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Bijouterie.SetActive(true);
			Bijouterie.transform.Translate(new Vector3(-taille/2, 0, 0));
			if (Gamer2.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		
		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Bijoutier"))
		{
			Gamer2 = new Bijouterie("Bijoutier");
			Gamer2.ready = true;
			multijoueur = true;
			TurnValues = 1;
			Bijouterie.SetActive(true);
			if (Gamer1.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		
		}
	}
	public void ChangementVetement()
	{
		
			ExitVetement(true);
	
	}
	
	public void ExitVetement(bool joueur)
	{
		verif = true;
		float taille = Screen.width;
		string s = "Prêt à porter";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Prêt à porter"))
		{
			Gamer1 = new Pret_a_porter("Prêt à porter");
			Gamer1.ready = true;
			if (true)
				{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
				}
				else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Vetement.SetActive(true);
			Vetement.transform.Translate(new Vector3(-taille/2, 0, 0));
			if (Gamer2.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		
		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Prêt à porter"))
		{
			Gamer2 = new Pret_a_porter("Prêt à porter");
			Gamer2.ready = true;
			multijoueur = true;
			TurnValues = 1;
			Vetement.SetActive(true);
			if (Gamer1.ready)
			{
				NonPerissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

	
		}
	}
	public void ChangementFleur()
	{
		
			ExitFleur(true);
		
	}
	
	public void ExitFleur(bool joueur)
	{
		verif = true;
			float taille = Screen.width;
		string s = "Fleuriste";
		if (joueur && (!Gamer2.ready || Gamer2._name != "Fleuriste"))
		{
			Gamer1 = new Fleuriste("Fleuriste");
			Gamer1.ready = true;
			if (true)
			{
					Gamer2 = new Primeur("Primeur");
					AI = new IntelligenceArtificielle();
					Gamer2.ready = true;
					Primeur.SetActive(true);
					Primeur.transform.Translate(new Vector3(taille/2, 0, 0));
			}
			else
			{
				Gamer2._money = 1_500;
			}
			TurnValues = 1;
			Fleuriste.SetActive(true);
			if (Gamer2.ready)
			{
				Perissable.SetActive(false);
				
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}
	

		}
		else if (!joueur && (!Gamer1.ready || Gamer1._name != "Fleuriste"))
		{
			Gamer2 = new Fleuriste("Fleuriste");
			Gamer2.ready = true;
			multijoueur = true;
			TurnValues = 1;
			Fleuriste.SetActive(true);
			Fleuriste.transform.Translate(new Vector3(taille/2, 0, 0));
			if (Gamer1.ready)
			{
				Perissable.SetActive(false);
				InfoTour.SetActive(true);
				InfoJoueur1.SetActive(true);
				InfoJoueur2.SetActive(true);
			}

		}
	}


	public void ExitDure(int nb)
	{
	
			ExitDureAux(nb);
	}


	public void ExitDureAux(int nb)
	{
		MaxTurn = nb;
		ChoixTour.SetActive(false);
		Difficulte.SetActive(true);
	}

	public void Retour()
	{
		float taille = Screen.width;
		Options.SetActive(false);
		GameOver.SetActive(false);
		if (Gamer2 is Primeur)
		{
			Primeur.transform.Translate(new Vector3(-taille/2, 0, 0));
		}
		Primeur.SetActive(false);
		if (Gamer1 is Libraire)
		{
			Librairie.transform.Translate(new Vector3(taille/2, 0, 0));
		}
		Librairie.SetActive(false);
		if (Gamer1 is Coiffeur)
		{
			Coiffeur.transform.Translate(new Vector3(taille/2, 0, 0));
		}
		Coiffeur.SetActive(false);
		if (Gamer2 is Poissonier)
		{
			Poissonerie.transform.Translate(new Vector3(-taille/2, 0, 0));
		}
		Poissonerie.SetActive(false);
		if (Gamer1 is Bijouterie)
		{
			Bijouterie.transform.Translate(new Vector3(taille/2, 0, 0));
		}
		Bijouterie.SetActive(false);
		if (Gamer1 is Pret_a_porter)
		{
			Vetement.transform.Translate(new Vector3(taille/2, 0, 0));
		}
		Fleuriste.SetActive(false);
		if (Gamer2 is Fleuriste)
		{
			Fleuriste.transform.Translate(new Vector3(-taille/2, 0, 0));
		}
		Vetement.SetActive(false);
		if (Gamer2 is Boucherie)
		{
			Boucherie.transform.Translate(new Vector3(-taille/2, 0, 0));
		}
		Boucherie.SetActive(false);
		InfoTour.SetActive(false);
		InfoJoueur1.SetActive(false);
		InfoJoueur2.SetActive(false);
		Accueil.SetActive(true);
		Gamer1.ready = false;
		Gamer2.ready = false;
	}

	public void AOptions()
	{
		Accueil.SetActive(false);
		Qualite.SetActive(false);
		Options.SetActive(true);
	}

	public void AQualite()
	{
		Options.SetActive(false);
		Qualite.SetActive(true);
	}

	public void ASon()
	{
		Options.SetActive(false);
	}
	public void DoButtonPass()
    {
		PlayerClass gamer;

			gamer = Gamer1;

        gamer._button = false;
        if (Gamer1._button == Gamer2._button)
        {
            CalCulus(Gamer1);
            CalCulus(Gamer2);
            CountdownScript.UpdateTimeButton(Gamer1);
        }
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
					ExitEnd();
				}
				else
					{
						gamer._mounth = 0;
						
					}
			}
			if (Gamer1._turn == false && Gamer2._turn == false)
			{
				Gamer1.TimeLeft = 100*Gamer1.nbCount;
				TourCount.AddTurn("");
				Gamer1._turn = true;
				Gamer2._turn = true;
				Gamer1._button = true;
				Gamer2._button = true;
				Gamer1.sum = 0;
				Gamer2.sum = 0;

				if (!(TourCount.TurnValues > TourCount.MaxTurn))
					AI.Act10();
			}
			if (TourCount.TurnValues > TourCount.MaxTurn || b)
			{
				ExitEnd();
			}
			else
				{
					ExitGeneral();
				}
        }
    }




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

	public void LessPrice(int p)
	{
		PlayerClass gamer;
	
			gamer = Gamer1;
	
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 3*NbScene+p)
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

	public void MorePrice(int p)
	{
		PlayerClass gamer;

			gamer = Gamer1;

		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == NbScene*3+p)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.10, b, d, k);
	
	}


	public void MoreApro(int n)
	{
		PlayerClass gamer;

			gamer = Gamer1;

		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 3*NbScene+n)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[3*NbScene+n-1]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			switch (3*NbScene+n)
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


	public void Promotion()
    {
		PlayerClass gamer;

			gamer = Gamer1;

		if (gamer.materiel[0] == "acheté")
        {
			gamer.promo = !gamer.promo;
			if (gamer.promo)
				gamer._stat["Attractivité"] *= 1.33;
			else
				gamer._stat["Attractivité"] /= 1.33;

		}
    }

	
    public void Employe()
    {
		PlayerClass gamer;

			gamer = Gamer1;

		if (gamer._stat["Employé"] > TextEmploye.n)
		{
			if (!gamer.AddMoney(-700*(gamer._stat["Employé"] - TextEmploye.n)))
				SceneManager.LoadScene("GameOver");
		}
        gamer._stat["Employé"] = TextEmploye.n;

    }
	
	public void Pub()
    {
		PlayerClass gamer;
	
			gamer = Gamer1;

		if(gamer.AddMoney(-1000))
			gamer._stat["Attractivité"] += 5;

    }

	public void Salaire()
	{
		PlayerClass gamer;

			gamer = Gamer1;

		gamer._stat["Qualité"] += (gamer._stat["Salaire"] - TextSalaire.n)/50; 
		gamer._stat["Salaire"] = TextSalaire.n;
		
	}


	public void Carte()
    {
		PlayerClass gamer;

			gamer = Gamer1;

		if(gamer.AddMoney(-100))
			gamer._stat["Attractivité"] += 0.5;

    }

    public void Magasin()
    {
		PlayerClass gamer;

			gamer = Gamer1;

        double n = TextMagasin.n;
        double n1 = gamer._stat["Magasin"];
        bool b = true;
        if (TextMagasin.n - 1 <= gamer._stat["Employé"])
        {
            if (n1 - n > 0)
                b = gamer.AddMoney(2500 * (n1 - n));
            else if (n1 - n < 0)
                b = gamer.AddMoney(5000 * (n1 - n));
            if (b)
                gamer._stat["Magasin"] = n;
            else
                TextMagasin.n = gamer._stat["Magasin"];
		
        }
    }



	public void Cadeau()
    {
		PlayerClass gamer;

			gamer = Gamer1;

		if(gamer.AddMoney(-500))
			gamer._stat["Attractivité"] += 2.5;

    }



	public void Prime()
	{
		PlayerClass gamer;

			gamer = Gamer1;

		if (gamer.AddMoney(-1000*gamer._stat["Employé"]) && gamer._stat["Employé"] != 0)
			gamer._stat["Qualité"] += 2*gamer._stat["Employé"];

	}


	public void AMateriel1()
    {
		PlayerClass gamer;

			gamer = Gamer1;

        if (gamer.materiel[0] != "acheté" && gamer.AddMoney(-200))
        {
           gamer.materiel[0] = "acheté";
           gamer._stat["Attractivité"] += 1;
        }
    }

   
   public void AMateriel(int p)
   {
	  PlayerClass gamer;
			gamer = Gamer1;

      if (gamer.materiel[p] != "acheté" && gamer.AddMoney(-2500))
      {
         gamer.materiel[p] = "acheté";
         gamer._stat["Attractivité"] += 5;
	
      }
   }



   public void MaterielG(int p)
	{
		PlayerClass gamer;

			gamer = Gamer1;
		
		if(gamer._missingitems[p-7] != "acheté" && gamer.AddMoney(-300))
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
				if (i == p)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[p-7] = "acheté";
			gamer._items[p-1] = s;
		
		}
	}

	

}