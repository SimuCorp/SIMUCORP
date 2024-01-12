using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static TextMagasin;

public class ButtonAct3 : MonoBehaviour
{
    
    public void DoAct3()
    {
		PlayerClass gamer = Gamer1;
        gamer._stat["Attracivité"] += 0.1;
        gamer.AddMoney(-100);
    }

    public void DoAct32()
    {
        double n = TextMagasin.n;
        double n1 = Gamer1._stat["Magasin"];
        bool b = true;
        if (n1 - n > 0)
            b = Gamer1.AddMoney(2500 * (n1 - n));
        else if (n1 - n < 0)
            b = Gamer1.AddMoney(5000 * (n1 - n));
        if (b)
            Gamer1._stat["Magasin"] = n;
		else
			TextMagasin.n = Gamer1._stat["Magasin"];
    }
    
}
