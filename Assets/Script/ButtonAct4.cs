using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class ButtonAct4 : MonoBehaviour
{
    
    public void DoAct4()
    {
        Gamer1._stat["Attracivité"] += 2.5;
        Gamer1.AddMoney(-500);
    }

    public void DoAct42()
    {
        if (Gamer1.AddMoney(-1000*Gamer1._stat["Employé"]) && Gamer1._stat["Employé"] != 0)
            Gamer1._stat["Qualité"] += 2*Gamer1._stat["Employé"];
    }
    
}
