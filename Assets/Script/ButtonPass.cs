using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class ButtonPass : MonoBehaviour
{
 

    public void NewButton()
    {
        if (Gamer1._button)
        {
            Gamer1._button = false;
            CalCulus(Gamer1, "");
        }
    }
    
}
