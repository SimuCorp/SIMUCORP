using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static MoneyCount;
using static TextSalaire;
using static PlayerScript;

public class ButtonAct2 : MonoBehaviour
{
    
    public void DoAct2()
    {
        PlayerClass gamer;
 
            gamer = Gamer1;
  
        gamer._stat["Attractivité"] += 5;
        gamer.AddMoney(-1000);
    }

    public void DoAct22()
    {
        PlayerClass gamer;

            gamer = Gamer1;
       
        gamer._stat["Qualité"] += (gamer._stat["Salaire"] - TextSalaire.n)/50; 
        gamer._stat["Salaire"] = TextSalaire.n;
    }
    
}
