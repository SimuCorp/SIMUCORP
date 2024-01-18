using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
using static TourCount;
public class ButtonExitCommercial : MonoBehaviour
{

    public void Exit()
    {
        SceneManager.LoadScene("ScenePrincipale");
    }

    public void ExitGestion()
    {
        SceneManager.LoadScene("ActionGestion");
    }

	public void ExitPrix1()
    {
        SceneManager.LoadScene("ActionPrix2");
    }

	public void ExitPrix2()
    {
        SceneManager.LoadScene("ActionPrix3");
    }
    
	public void ExitPrix3()
    {
        SceneManager.LoadScene("ActionPrix4");
    }
	
	public void ExitPrix4()
    {
        SceneManager.LoadScene("ActionPrix1");
    }
	
	public void ExitApro1()
	{
		SceneManager.LoadScene("ActionApro2");
	}

	public void ExitApro2()
	{
		SceneManager.LoadScene("ActionApro3");
	}

	public void ExitApro3()
	{
		SceneManager.LoadScene("ActionApro4");
	}

	public void ExitApro4()
	{
		SceneManager.LoadScene("ActionApro1");
	}
	
	public void ExitQuali1()
	{
		SceneManager.LoadScene("ActionQuali2");
	}

	public void ExitQuali2()
	{
		SceneManager.LoadScene("ActionQuali3");
	}

	public void ExitQuali3()
	{
		SceneManager.LoadScene("ActionQuali4");
	}

	public void ExitQuali4()
	{
		SceneManager.LoadScene("ActionQuali1");
	}
	
	public void ExitMateriel1()
	{
		int i = 0;
		int length = Gamer1._items.Count;

		while (i < length && Gamer1._items[i] == "done")
			++i;
		if (i < length)
			SceneManager.LoadScene("ActionMateriel2");
	}

	public void ExitMateriel2()
	{
		SceneManager.LoadScene("ActionMateriel3");
	}

	public void ExitMateriel3()
	{
		SceneManager.LoadScene("ActionMateriel1");
	}

	public void ExitAccueil()
	{
		SceneManager.LoadScene("ChoixTour");
	}

	public void Simple()
	{
		SceneManager.LoadScene("NonPerissable");
	}

	public void Difficile()
	{
		SceneManager.LoadScene("Perissable");
	}

	public void ExitPrimeur()
	{
		Gamer1 = new Primeur("Primeur");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitBoucherie()
	{
		Gamer1 = new Boucherie("Boucher");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitLibraire()
	{
		Gamer1 = new Libraire("Libraire");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitCoiffeur()
	{
		Gamer1 = new Coiffeur("Coiffeur");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitPoisson()
	{
		Gamer1 = new Poissonier("Poissonier");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitBijouterie()
	{
		Gamer1 = new Bijouterie("Bijoutier");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitVetement()
	{
		Gamer1 = new Pret_a_porter("Prêt à porter");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitFleur()
	{
		Gamer1 = new Fleuriste("Fleuriste");
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitCourte()
	{
		MaxTurn = 13;
		SceneManager.LoadScene("ChoixDifficulté");
	}

	public void ExitMoyenne()
	{
		MaxTurn = 26;
		SceneManager.LoadScene("ChoixDifficulté");
	}
		
	public void ExitLongue()
	{
		MaxTurn = 52;
		SceneManager.LoadScene("ChoixDifficulté");
	}

	public void Retour()
	{
		SceneManager.LoadScene("EcranAccueil");
	}
}
