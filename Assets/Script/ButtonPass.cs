using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using static MoneyCount;

public class ButtonPass : NetworkBehaviour
{
 

    public void NewButton()
    {
        PlayerClass gamer;
        if (this.isServer)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        if (gamer._button)
        {
            gamer._button = false;
            CalCulus(gamer, "");
        }
    }
    
}
