using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using static MoneyCount;
using static TextEmploye;
using static PlayerScript;

public class ButtonAct1 : MonoBehaviour
{
    
	public void DoAct1()
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

	public void DoAct12()
	{
		PlayerClass gamer;

			gamer = Gamer1;

		if (gamer._stat["Employé"] > TextEmploye.n)
		{
			if (!gamer.AddMoney(-700*(gamer._stat["Employé"] - TextEmploye.n)))
				{
					SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
				}
		}
		gamer._stat["Employé"] = TextEmploye.n;
	}
	
	public void DoAct13()
	{
		SceneManager.LoadScene("ActionPrix1", LoadSceneMode.Additive);
	}
	public void Prix1()
	{
	}
}
