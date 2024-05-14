using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class ButtonAct4 : MonoBehaviour
{
    
    public void DoAct4()
    {
        PlayerClass gamer;
 
            gamer = Gamer1;

        gamer._stat["Attractivité"] += 2.5;
        gamer.AddMoney(-500);
    }

    public void DoAct42()
    {
        PlayerClass gamer;
     
            gamer = Gamer1;
   
        if (gamer.AddMoney(-1000*gamer._stat["Employé"]) && gamer._stat["Employé"] != 0)
            gamer._stat["Qualité"] += 2*gamer._stat["Employé"];
    }
    
}
