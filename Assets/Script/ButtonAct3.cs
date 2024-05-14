using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static MoneyCount;
using static TextMagasin;
using static PlayerScript;

public class ButtonAct3 : MonoBehaviour
{   
    public void DoAct3()
    {
        PlayerClass gamer;

            gamer = Gamer1;

        gamer._stat["Attractivité"] += 0.5;
        gamer.AddMoney(-100);
    }

    public void DoAct32()
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
    
}
