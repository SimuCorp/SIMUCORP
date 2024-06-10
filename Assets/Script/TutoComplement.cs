using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static MoneyCount;
using UnityEngine.SceneManagement;
using System.Threading;
using static TextTuto;
using static System.Math;
using static PlayerScript;
using static TextActionJoueur1;
public class TutoComplement : MonoBehaviour
{

    public Text Info;
    public string s;
    public bool b1;
    public bool b2;
    public bool b3;
    public bool b4;
    public bool b5;
    public bool b6;
    public bool b7;
    public bool b8;
    public bool b9;
    public bool b10;
    public bool b11;
    public bool b12;
    public bool b13;
    public bool b14;
    public bool b15;
    public bool b16;
    // Start is called before the first frame update
    void Start()
    {
        Info = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(TextTuto.i)
        {
            case(0) when b1:
                Info.text = s;
                break;
            case(1) when b2:
                Info.text = s;
                break;
            case(2) when b3:
                Info.text = s;
                break;
            case(3) when b4:
                Info.text = s;
                break;

            case(4) when b5:
                Info.text = s;
                break;
            case(5) when b6:
                Info.text = s;
                break;
            case(6) when b7:
                Info.text = s;
                break;
            case(7) when b8:
                Info.text = s;
                break;
            case(8) when b9:
                Info.text = s;
                break;

            case(9) when b10:
                Info.text = s;
                break;
            case(10) when b11:
                Info.text = s;
                break;
            case(11) when b12:
                Info.text = s;
                break;
            case(12) when b13:
                Info.text = s;
                break;
            case(13) when b14:
                Info.text = s;
                break;
            case(14) when b15:
                Info.text = s;
                break;
            case(15) when b16:
                Info.text = s;
                break;
            default:
                Info.text = "";
                break;
        }
    }
}
