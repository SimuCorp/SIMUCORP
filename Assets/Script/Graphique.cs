using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;

public class Graphique : MonoBehaviour
{
    public Image basic;
    public Sprite augmente;
    public Sprite stagne;
    public Sprite dimin;
    void Start()
    {
        double x = basic.transform.position.x;
        double x2 = Screen.width/2;
        double sum;
        if (x <= x2)
            sum = Round(TextActionJoueur1.diff1, 2);
        else
            sum = Round(TextActionJoueur1.diff2, 2);
        if (sum > 0)
            basic.sprite = augmente;
        else if (sum < 0)
            basic.sprite = dimin;
        else
            basic.sprite  = stagne;
    }

    // Update is called once per frame
    void Update()
    {
        double x = basic.transform.position.x;
        double x2 = Screen.width/2;
        double sum;
        if (x <= x2)
            sum = Round(TextActionJoueur1.diff1, 2);
        else
            sum = Round(TextActionJoueur1.diff2, 2);
        if (sum > 0)
            basic.sprite = augmente;
        else if (sum < 0)
            basic.sprite = dimin;
        else
            basic.sprite  = stagne;
    }
}
