using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;
using static MoneyCount;
using static TourCount;
public class ButtonExitCommercial : NetworkBehaviour 
{
	public static bool changement = false;

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

		while (i < length && Gamer1._items[i] == "done")
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
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ChoixTour", LoadSceneMode.Additive);
	}

	public void Simple()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("NonPerissable",  LoadSceneMode.Additive);
	}

	public void Difficile()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("Perissable",  LoadSceneMode.Additive);
	}

	public void ExitPrimeur()
	{
		if (this.isServer)
		{
			Gamer1 = new Primeur("Primeur");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Primeur("Primeur");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}	
	}

	public void ExitBoucherie()
	{
		if (this.isServer)
		{
			Gamer1 = new Boucherie("Boucher");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Boucherie("Boucher");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitLibraire()
	{
		if (this.isServer)
		{
			Gamer1 = new Libraire("Libraire");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Libraire("Libraire");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitCoiffeur()
	{
		if (this.isServer)
		{
			Gamer1 = new Coiffeur("Coiffeur");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Coiffeur("Coiffeur");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitPoisson()
	{
		if (this.isServer)
		{
			Gamer1 = new Poissonier("Poissonier");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Poissonier("Poissonier");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitBijouterie()
	{
		if (this.isServer)
		{
			Gamer1 = new Bijouterie("Bijoutier");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Bijouterie("Bijoutier");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitVetement()
	{
		if (this.isServer)
		{
			Gamer1 = new Pret_a_porter("Prêt à porter");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Pret_a_porter("Prêt à porter");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitFleur()
	{
		if (this.isServer)
		{
			Gamer1 = new Fleuriste("Fleuriste");
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
		else if (!multijoueur)
		{
			Gamer2 = new Fleuriste("Fleuriste");
			multijoueur = true;
			TurnValues = 1;
			Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
			++Gamer1.nbCount;
			SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
		}
	}

	public void ExitCourte()
	{
		MaxTurn = 13;
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;	
		SceneManager.LoadScene("ChoixDifficulté",  LoadSceneMode.Additive);
	}

	public void ExitMoyenne()
	{
		MaxTurn = 26;
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ChoixDifficulté",  LoadSceneMode.Additive);
	}
		
	public void ExitLongue()
	{
		MaxTurn = 52;
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ChoixDifficulté",  LoadSceneMode.Additive);
	}

	public void Retour()
	{
		Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("EcranAccueil",  LoadSceneMode.Additive);
	}
}
