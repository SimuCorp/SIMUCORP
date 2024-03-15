using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
using static TextEmploye;

public class ButtonAct1 : MonoBehaviour
{
    
	public void DoAct1()
	{
		if (Gamer1.materiel[0] == "done")
		{
			Gamer1.promo = !Gamer1.promo;
			if (Gamer1.promo)
				Gamer1._stat["Attracivité"] *= 1.33;
			else
				Gamer1._stat["Attracivité"] /= 1.33;
		}
	}

	public void DoAct12()
	{
		if (Gamer1._stat["Employé"] > TextEmploye.n)
		{
			if (!Gamer1.AddMoney(-700*(Gamer1._stat["Employé"] - TextEmploye.n)))
				SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
		}
		Gamer1._stat["Employé"] = TextEmploye.n;
	}
	
	public void DoAct13()
	{
		SceneManager.LoadScene("ActionPrix1", LoadSceneMode.Additive);
	}
	public void Prix1()
	{
	}
}
