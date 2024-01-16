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
        PlayerClass gamer = Gamer1;
        System.Random aleatoire = new System.Random();
        int key = aleatoire.Next(0, gamer._items.Count);
        gamer.promo = !gamer.promo;
		if (gamer.promo)
			gamer._stat["Attracivité"] += 25;
		else
			gamer._stat["Attracivité"] -= 25;
    }

    public void DoAct12()
    {
        Gamer1._stat["Employé"] = TextEmploye.n;
    }
	
	public void DoAct13()
	{
		SceneManager.LoadScene("ActionPrix1");
	}
	public void Prix1()
	{
	}
}
