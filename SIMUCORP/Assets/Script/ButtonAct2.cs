using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;
using static TextSalaire;

public class ButtonAct2 : NetworkBehaviour 
{
    
    public void DoAct2()
    {
        PlayerClass gamer;
        if (isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        gamer._stat["Attracivité"] += 5;
        gamer.AddMoney(-1000);
    }

    public void DoAct22()
    {
        PlayerClass gamer;
        if (isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        gamer._stat["Qualité"] += (gamer._stat["Salaire"] - TextSalaire.n)/50; 
        gamer._stat["Salaire"] = TextSalaire.n;
    }
    
}
