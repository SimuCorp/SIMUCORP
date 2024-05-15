using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static PlayerScript;

public class ButtonAct4 : NetworkBehaviour 
{
    
    public void DoAct4()
    {
        PlayerClass gamer;
        if (isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        gamer._stat["Attractivité"] += 2.5;
        gamer.AddMoney(-500);
    }

    public void DoAct42()
    {
        PlayerClass gamer;
        if (isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        if (gamer.AddMoney(-1000*gamer._stat["Employé"]) && gamer._stat["Employé"] != 0)
            gamer._stat["Qualité"] += 2*gamer._stat["Employé"];
    }
    
}
