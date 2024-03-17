using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MoneyCount;

public class Devanture2 : MonoBehaviour
{
    public Image basic;
    public Sprite boucherie;
    public Sprite boucherie_rotisoire;
    public Sprite primeur;
    public Sprite primeur_vide;
    public Sprite primeur_rempli;
    public Sprite librairie;
    public Sprite librairie_g;
    public Sprite coiffeur;
    public Sprite coiffeur_desserte;
    public Sprite coiffeur_casque;
    void Start()
    {
        basic = GetComponent<Image>();
        PlayerClass gamer = Gamer2;
        if (gamer is Primeur p)
        {
            if (p.materiel[1] == "acheté" || p.materiel[2] == "acheté")
            {
                int res = 0;
                int i = 0;
                foreach(string s in p._marchandise.Keys)
                {
                    (int a, double j, bool b, double d, int k) = p._marchandise[s];
                    res += a;
                    if (i == 5)
                        break;
                    ++i;
                }
                if (res >= 300)
                    basic.sprite = primeur_rempli;
                else
                    basic.sprite = primeur_vide;
            }
            else
                basic.sprite = primeur;
        }
        else if (gamer is Libraire l)
            {
                if (l.materiel[1] == "acheté")
                    basic.sprite = librairie_g;
                else
                    basic.sprite = librairie;
            }
        else if (gamer is Coiffeur c)
            {
                if (c.materiel[1] == "acheté")
                {
                     if (c.materiel[2] == "acheté")
                        basic.sprite = coiffeur_casque;
                     else
                        basic.sprite = coiffeur_desserte;
                }
                else
                    basic.sprite = coiffeur;
            }
        else if (gamer is Boucherie b)
        {
            if (b.materiel[1] == "acheté")
                basic.sprite = boucherie_rotisoire;
            else
                basic.sprite = boucherie;
        }
        else
            basic.sprite = boucherie;
    }
    void Update()
    {

    }
}

