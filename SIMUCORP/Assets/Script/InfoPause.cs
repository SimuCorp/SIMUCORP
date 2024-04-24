using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using UnityEngine.SceneManagement;
using System.Threading;
using Mirror;
using static PlayerScript;

public class infoPause : NetworkBehaviour
{
    public Text Info;
    public static int n = 0;
    void Start()
    {
        Info = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        double x = Info.transform.position.x;
		double x2 = Screen.width/2;
		if (((this.isServer && x <= x2) || (!this.isServer && x >= x2)))
		{
            PlayerClass gamer;
			if (this.isServer)
				gamer = Gamer1;
			else
				gamer = Gamer2;
            if (Input.GetKeyDown(KeyCode.RightArrow))
                n = (n+1)%12;
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
                n = (n+11)%12;
            Info.text = gamer.Display(n);
            if (Info.text.Contains("Indisponible"))
                Info.color = Color.red;
            else
                Info.color = Color.green;

        }
        else
        {
            PlayerClass gamer;
            if (!this.isServer)
				gamer = Gamer1;
			else
				gamer = Gamer2;
            Info.text = gamer.Display(n);
            if (Info.text.Contains("Indisponible"))
                Info.color = Color.red;
            else
                Info.color = Color.green;
        }
    }
}
