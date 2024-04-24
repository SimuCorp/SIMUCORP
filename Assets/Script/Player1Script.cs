using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static PlayerScript;
using static TextActionJoueur1;
using static System.Math;


public class Player1Script : MonoBehaviour
{

    public static bool move {get; set;}
    public static bool amelioration1 {get; set;}
    public static bool amelioration2 {get; set;}
    public static int act {get; set;} 
    public GameObject Joueur;
    public AudioSource collision;
 
    // Start is called before the first frame update
    void Start()
    {
        move = true;
        amelioration1 = true;
        amelioration2 = true;
        act = 0;
        collision = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        double x = Joueur.transform.position.x;
        double x2 = Screen.width/2;
        if (move && ((true && x <= x2) || (!true && x >= x2)))
        {
            transform.Translate(Vector3.up * 30f * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
            transform.Translate(Vector3.right * 30f * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        }
    }

    void OnCollisionEnter2D (Collision2D collision )
    {

        double x = collision.transform.position.x;
        double y = collision.transform.position.y;
        if��(collision.gameObject.name�==��"mur_bas"�)��
        {
            transform.Translate(new Vector2(0,1) * 10);
        }
        else if��(collision.gameObject.name�==��"mur_haut"�)��
        {
            transform.Translate(new Vector2(0,-1) * 10);
        }
        else if��(collision.gameObject.name�==��"mur_droite"�)��
        {
            transform.Translate(new Vector2(-1,0) * 10);
        }
        else if��(collision.gameObject.name�==��"mur_gauche"�)��
        {
            transform.Translate(new Vector2(1,0) * 10);
        }
        else
        {
            double x2 = Joueur.transform.position.x;
            double y2 = Joueur.transform.position.y;
            if (y < y2)
                transform.Translate(new Vector2(0,1) * 10);
            if (y > y2)
                transform.Translate(new Vector2(0,-1) * 10);
            if (x < x2)
                transform.Translate(new Vector2(1,0) * 10);
            if (x > x2)
                transform.Translate(new Vector2(-1,0) * 10);
                
        }
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerClass gamer;
 
            gamer = Gamer1;

        if (other.gameObject.CompareTag("amelioration1") && amelioration1)
        {
            if (gamer._money < 2500)
				action.color = Color.red;
			else
				action.color = Color.green;
            TextActionJoueur1.action.text = gamer.materiel[1] + " : 2500 $";
            move = false;
        }
        else if (other.gameObject.CompareTag("amelioration2") && amelioration2)
        {
            if (gamer._money < 2500)
				action.color = Color.red;
			else
				action.color = Color.green;
            TextActionJoueur1.action.text = gamer.materiel[2] + " : 2500 $";
            move = false;
        }
        else if (other.gameObject.CompareTag("item1"))
        {      
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[0]];
            TextActionJoueur1.action.text = "Quantit� de " + gamer._items[0] + $" : {n}";
            move = false;
            act = 0;
            if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("item2"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[1]];
            TextActionJoueur1.action.text = "Quantit� de " + gamer._items[1] + $" : {n}";
            move = false;
            act = 1;
            if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("item3"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[2]];
            TextActionJoueur1.action.text = "Quantit� de " + gamer._items[2] + $" : {n}";
            move = false;
            act = 2;
            if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("item4"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[3]];
            TextActionJoueur1.action.text = "Quantit� de " + gamer._items[3] + $" : {n}";
            move = false;
            act = 3;
            if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("item5"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[4]];
            TextActionJoueur1.action.text = "Quantit� de " + gamer._items[4] + $" : {n}";
            move = false;
            act = 4;
            if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("item6"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[5]];
            TextActionJoueur1.action.text = "Quantit� de " + gamer._items[5] + $" : {n}";
            move = false;
            act = 5;
            if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("item7"))
        {
            move = false;
            act = 6;
            if(gamer._items[6] == "NaN")
            {
                TextActionJoueur1.action.text = gamer._missingitems[0] + " : 300 $";
                if (300>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[6]];
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[6] + $" : {n}";
                move = false;
                if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
        }
        else if (other.gameObject.CompareTag("item8"))
        {
            move = false;
            act = 7;
            if(gamer._items[7] == "NaN")
             {
                 TextActionJoueur1.action.text = gamer._missingitems[1] + " : 300 $";
                 if (300>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
             }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[7]];
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[7] + $" : {n}";
                move = false;
                if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
        }
        else if (other.gameObject.CompareTag("item9"))
        {
            move = false;
            act = 8;
            if(gamer._items[8] == "NaN")
            {
                TextActionJoueur1.action.text = gamer._missingitems[2] + " : 300 $";
                if (300>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[8]];
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[8] + $" : {n}";
                move = false;
                if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
        }
        else if (other.gameObject.CompareTag("item10"))
        {
            move = false;
            act = 9;
            if(gamer._items[9] == "NaN")
            {
                TextActionJoueur1.action.text = gamer._missingitems[3] + " : 300 $";
                if (300>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[9]];
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[9] + $" : {n}";
                move = false;
                if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
        }
        else if (other.gameObject.CompareTag("item11"))
        {
            act = 10;
            if(gamer._items[10] == "NaN")
            {
                    TextActionJoueur1.action.text = gamer._missingitems[4] + " : 300 $";
                    move = false;
                    if (300>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[10]];
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[10] + $" : {n}";
                move = false;
                if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
        }
        else if (other.gameObject.CompareTag("item12"))
        {
            move = false;
            act = 11;
            if(gamer._items[11] == "NaN")
            {
                TextActionJoueur1.action.text = gamer._missingitems[5] + " : 300 $";
                if (300>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[11]];
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[11] + $" : {n}";
                if (j*5>gamer._money)
                    TextActionJoueur1.action.color = Color.red;
                else 
                    TextActionJoueur1.action.color = Color.green;
                move = false;
            }
        }
        else if (other.gameObject.CompareTag("Caisse"))
        {
            move = false;
            TextActionJoueur1.action.text = $"Nombre d'employ�s : {gamer._stat["Employ�"]}";
            TextActionJoueur1.action.color = Color.green;
        }
        else if (other.gameObject.CompareTag("promotion"))
        {
            move = false;
            if (gamer.materiel[0] != "achet�")
            {
                TextActionJoueur1.action.text = "Tableau de promotion : 300 $";
                if (gamer._money < 300)
                    TextActionJoueur1.action.color = Color.red;
                else
                    TextActionJoueur1.action.color = Color.green;
            }
            else
            {
                TextActionJoueur1.action.color = Color.green;
                if (gamer.promo)
                    TextActionJoueur1.action.text = "Promotion en cours";
                else
                    TextActionJoueur1.action.text = "Promotion en attente";
            }
        }
        else if (other.gameObject.CompareTag("Mur"))
        {
            collision.Play();
        }
    }

    public static void ChangementText(int n, bool verif)
    {
        PlayerClass gamer;
        if (verif)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        if (gamer._items[n] != "NaN")
        {
            (int m, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[n]];
            if ((TextActionJoueur1.action.text.Contains("Quantit� de") 
                && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("de niveau") && Input.GetKeyDown(KeyCode.UpArrow)))
                    TextActionJoueur1.action.text = "Prix de " + gamer._items[n] + $" : {j} $";
            else if ((TextActionJoueur1.action.text.Contains("Prix de") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Quantit� de") && Input.GetKeyDown(KeyCode.UpArrow)))
                TextActionJoueur1.action.text = gamer._items[n] + " de niveau " +$"{d}"+$" : {50*Math.Pow(d, 2)} $";
            else if (
            (TextActionJoueur1.action.text.Contains("de niveau") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Prix de") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Quantit� de " + gamer._items[n] + $" : {m}";

            }
            else if ((TextActionJoueur1.action.text.Contains("Finir") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("magasins") && Input.GetKeyDown(KeyCode.UpArrow)))
                TextActionJoueur1.action.text = $"Salaire : {gamer._stat["Salaire"]} $";
            else if ((TextActionJoueur1.action.text.Contains("Salaire") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Prime") && Input.GetKeyDown(KeyCode.UpArrow)))
                TextActionJoueur1.action.text = $"Nombre de magasins : {gamer._stat["Magasin"]}";
            else if ((TextActionJoueur1.action.text.Contains("magasins") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Cartes") && Input.GetKeyDown(KeyCode.UpArrow)))
                TextActionJoueur1.action.text = "Prime : 1000 $/employ�";
            else if ((TextActionJoueur1.action.text.Contains("Prime") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Cadeaux") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Cartes de fid�lit� : 100 $";
            }
            else if ((TextActionJoueur1.action.text.Contains("Cartes") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Publicit�") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Cadeaux : 500 $";
            }
            else if ((TextActionJoueur1.action.text.Contains("Cadeaux") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("employ�s :") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Publicit� : 1000 $";
            }
            else if ((TextActionJoueur1.action.text.Contains("Publicit�") && Input.GetKeyDown(KeyCode.DownArrow)) ||(TextActionJoueur1.action.text.Contains("Finir") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = $"Nombre d'employ�s : {gamer._stat["Employ�"]}";
                TextActionJoueur1.action.color = Color.green;
            }
             else if ((TextActionJoueur1.action.text.Contains("employ�s :") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Salaire") && Input.GetKeyDown(KeyCode.UpArrow)))
             {
                 TextActionJoueur1.action.text = "Finir son tour";
                TextActionJoueur1.action.color = Color.green;
             }
        }
            
    }
}