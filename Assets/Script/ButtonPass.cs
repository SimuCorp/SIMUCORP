using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static MoneyCount;
using static PlayerScript;

public class ButtonPass : MonoBehaviour
{
 

    public void NewButton()
    {
        PlayerClass gamer;
 
            gamer = Gamer1;
  
        if (gamer._button)
        {
            gamer._button = false;
            CalCulus(gamer, "");
        }
    }
    
}
