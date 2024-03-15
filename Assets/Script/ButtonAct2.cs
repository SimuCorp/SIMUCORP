using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;
using static TextSalaire;

public class ButtonAct2 : MonoBehaviour
{
    
    public void DoAct2()
    {
        Gamer1._stat["Attracivité"] += 5;
        Gamer1.AddMoney(-1000);
    }

    public void DoAct22()
    {
        Gamer1._stat["Qualité"] += (Gamer1._stat["Salaire"] - TextSalaire.n)/50; 
        Gamer1._stat["Salaire"] = TextSalaire.n;
    }
    
}
