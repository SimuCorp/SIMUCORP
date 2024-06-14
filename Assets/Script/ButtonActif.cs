using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using static PlayerScript;

public class ButtonActif : NetworkBehaviour
{
    Button button;
    public bool choix;
    void Start()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (choix)
        {
            if (this.isServer)
            {
                button.interactable = !Gamer1.ready;
            }
            else
            {
                button.interactable = !Gamer2.ready;
            }
        }
        else
        {
            button.interactable = this.isServer;
        }
    }
}
