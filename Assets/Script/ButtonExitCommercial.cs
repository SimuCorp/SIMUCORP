using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using static MoneyCount;
using static TourCount;
using static IntelligenceArtificielle;
using static PlayerScript;
public class ButtonExitCommercial : MonoBehaviour
{
	public static bool changement = false;
	public static bool changement2 = false;

    public void Exit()
    {
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
        SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
    }

    public void ExitGestion()
    {
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
        SceneManager.LoadScene("ActionGestion",  LoadSceneMode.Additive);
    }

	public void ExitPrix1()
    {
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
        SceneManager.LoadScene("ActionPrix2",  LoadSceneMode.Additive);
    }

	public void ExitPrix2()
    {
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
        SceneManager.LoadScene("ActionPrix3",  LoadSceneMode.Additive);
    }
    
	public void ExitPrix3()
    {
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
        SceneManager.LoadScene("ActionPrix4",  LoadSceneMode.Additive);
    }
	
	public void ExitPrix4()
    {
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
        SceneManager.LoadScene("ActionPrix1",  LoadSceneMode.Additive);
    }
	
	public void ExitApro1()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionApro2",  LoadSceneMode.Additive);
	}

	public void ExitApro2()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionApro3",  LoadSceneMode.Additive);
	}

	public void ExitApro3()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionApro4",  LoadSceneMode.Additive);
	}

	public void ExitApro4()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionApro1",  LoadSceneMode.Additive);
	}
	
	public void ExitQuali1()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionQuali2",  LoadSceneMode.Additive);
	}

	public void ExitQuali2()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionQuali3",  LoadSceneMode.Additive);
	}

	public void ExitQuali3()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionQuali4",  LoadSceneMode.Additive);
	}

	public void ExitQuali4()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionQuali1",  LoadSceneMode.Additive);
	}
	
	public void ExitMateriel1()
	{
		int i = 0;
		int length = Gamer1._items.Count;

		while (i < length && Gamer1._items[i] == "acheté")
			++i;
		if (i < length)
		{
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ActionMateriel2",  LoadSceneMode.Additive);
		}
	}

	public void ExitMateriel2()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionMateriel3",  LoadSceneMode.Additive);
	}

	public void ExitMateriel3()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionMateriel1",  LoadSceneMode.Additive);
	}
	
	public void ExitAccueil()
	{
		
			OpponentAccueilClientRpc();
	
	}
	
	public void OpponentAccueilClientRpc()
	{
		SceneManager.UnloadSceneAsync("EcranAccueil");
		SceneManager.LoadSceneAsync("ChoixTour", LoadSceneMode.Additive);
	}

	public void OpponentAccueilServer()
	{
		SceneManager.UnloadSceneAsync("EcranAccueil");
		SceneManager.LoadSceneAsync("ChoixTour", LoadSceneMode.Additive);
	}

	public void Simple()
	{
		SceneManager.LoadScene("NonPerissable",  LoadSceneMode.Additive);
	}

	public void Difficile()
	{
		SceneManager.LoadScene("Perissable",  LoadSceneMode.Additive);
	}

	public void ExitPrimeur()
	{
		if (true)
		{
			Gamer1 = new Primeur("Primeur");
			if (!(multijoueur))
				{
					Gamer2 = new Boucherie("Boucher");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Primeur("Primeur");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}	
	}

	public void ExitBoucherie()
	{
		if (true)
		{
			Gamer1 = new Boucherie("Boucher");
			if (!(multijoueur))
				{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Boucherie("Boucher");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitLibraire()
	{
		if (true)
		{
			Gamer1 = new Libraire("Libraire");
			if (!(multijoueur))
				{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Libraire("Libraire");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitCoiffeur()
	{
		if (true)
		{
			Gamer1 = new Coiffeur("Coiffeur");
			if (!(multijoueur))
				{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Coiffeur("Coiffeur");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitPoisson()
	{
		if (true)
		{
			Gamer1 = new Poissonier("Poissonier");
			if (!(multijoueur))
				{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Poissonier("Poissonier");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitBijouterie()
	{
		if (true)
		{
			Gamer1 = new Bijouterie("Bijoutier");
			if (!(multijoueur))
				{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Bijouterie("Bijoutier");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitVetement()
	{
		if (true)
		{
			Gamer1 = new Pret_a_porter("Prêt à porter");
			if (!(multijoueur))
				{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
				}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Pret_a_porter("Prêt à porter");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitFleur()
	{
		if (true)
		{
			Gamer1 = new Fleuriste("Fleuriste");
			if (!(multijoueur))
			{
					Gamer2 = new Primeur("Primeur");
					new IntelligenceArtificielle();
			}
			TurnValues = 1;
			changement2 = true;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Fleuriste("Fleuriste");
			multijoueur = true;
			TurnValues = 1;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitCourte()
	{
		MaxTurn = 13;
		SceneManager.LoadScene("ChoixDifficulté",  LoadSceneMode.Additive);
	}

	public void ExitMoyenne()
	{
		MaxTurn = 26;
		SceneManager.LoadScene("ChoixDifficulté",  LoadSceneMode.Additive);
	}
		
	public void ExitLongue()
	{
		MaxTurn = 52;
		SceneManager.LoadScene("ChoixDifficulté",  LoadSceneMode.Additive);
	}

	public void Retour()
	{
		Gamer1.TimeLeft = 100;
        Gamer1.nbCount = 1;
		multijoueur = false;
		changement2 = false;
		SceneManager.LoadScene("EcranAccueil",  LoadSceneMode.Single);
	}

	public void reglage()
	{
		SceneManager.LoadScene("Réglage",  LoadSceneMode.Additive);
	}

	public void qualite()
	{
		SceneManager.LoadScene("Qualite",  LoadSceneMode.Additive);
	}

	public void son()
	{
		SceneManager.LoadScene("Son",  LoadSceneMode.Additive);
	}

	public void DoButtonCommercial()
	{
        Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionCommercial",  LoadSceneMode.Additive);
	}

	public void DoButtonGestion()
	{
        Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionGestion",  LoadSceneMode.Additive);
	}

	public void NewButton()
    {
        PlayerClass gamer;
   
            gamer = Gamer1;

        if (gamer._button)
        {
            gamer._button = false;
            CalCulus(gamer, "");
        }
    }

	public void DoButtonRH()
	{
        Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionRH",  LoadSceneMode.Additive);
	}
}
