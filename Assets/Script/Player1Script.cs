using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static PlayerScript;
using static TextActionJoueur1;
using static System.Math;
using Mirror;

public class Player1Script : NetworkBehaviour
{

    public static bool move {get; set;}
    public static bool amelioration1 {get; set;}
    public static bool amelioration2 {get; set;}
    public static int act {get; set;} 
    [SerializeField] public GameObject Joueur;
    public AudioSource collision;
    public Image Emplacement1;
	public Image Emplacement2;
    public static Sprite im1;
    public static Sprite im2;
    public static float position {get; set;}
    public Sprite fond;
    public Sprite Amelioration1;
    public Sprite Amelioration2;
    public GameObject textaction;
    public double last_x;
    public double last_y;
    public static double timecol;
    public float angle;

    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        move = true;
        position = Joueur.transform.position.x;
        last_x = 0;
        last_y = 0;
        Emplacement1.sprite = fond;
		Emplacement2.sprite = fond;
        amelioration1 = true;
        amelioration2 = true;
        act = 0;
        collision = GetComponent<AudioSource>();
        angle = 0;
        timecol = 130;
        im1 = Emplacement1.sprite;
        im2 = Emplacement2.sprite;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        double x = Joueur.transform.position.x;
        double x2 = Screen.width/2;
        if (timecol-0.2 > Gamer1.TimeLeft)
            timecol = 130;
        if (Gamer1.TimeLeft > 125 || (TourCount.TurnValues == 1 && Gamer1.TimeLeft >= 119.8 && Gamer1.ready && Gamer2.ready))
        {
            if (x <= x2)
                transform.position = new Vector2((float)(x2/2),(float)(Screen.height/4));
            else
                transform.position = new Vector2((float)(x2/2*3),(float)(Screen.height/4));
            timecol = 130;
        }
        else if (timecol-0.2<= Gamer1.TimeLeft && Gamer1.TimeLeft < 120)
        {

        }
        else if (move && !PlayerScript.pause)
        {   
            double vert = Input.GetAxis("Vertical");
            last_y = vert;
            double hori = Input.GetAxis("Horizontal");
            last_x = hori;
            if (NetworkServer.active && x <= x2)
            {
                
                    OpponentMove(vert, hori);
            }
            else if (!NetworkServer.active && x >= x2)
            {
                OpponentMoveServerRpc(vert, hori);
            }
        }
        if (x <= x2)
        {
            if (Gamer1.materiel[1] == "acheté")
                Emplacement1.sprite = Amelioration1;
            else
                Emplacement1.sprite = im1;
			if (Gamer1.materiel[2] == "acheté")
				Emplacement2.sprite = Amelioration2;
            else
                Emplacement2.sprite = im2;
        }
        else
        {
            if (Gamer2.materiel[1] == "acheté")
				Emplacement1.sprite = Amelioration1;
            else
                Emplacement1.sprite = im1;
			if (Gamer2.materiel[2] == "acheté")
				Emplacement2.sprite = Amelioration2;
            else
                Emplacement2.sprite = im2;
        }

    }

    [Command(requiresAuthority = false)]
	private void OpponentMoveServerRpc(double x, double x2) => OpponentMove(x, x2);

	[ClientRpc]
	private void OpponentMove(double x, double x2)
    {
        /*
            if (x < 0)
            {
                if (x2 == 0)
                {
                    transform.Rotate(new Vector3(0, 0, -angle));
                    angle = 0;
                }
                else if (x2 > 0)
                {
                    transform.Rotate(new Vector3(0, 0, 45-angle));
                    angle = 45;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, -45-angle));
                    angle = -45;
                }

            }
            else if (x < 0)
            {
                if (x2 == 0)
                {
                    transform.Rotate(new Vector3(0, 0, 180-angle));
                    angle = 180;
                }
                else if (x2 > 0)
                {
                    transform.Rotate(new Vector3(0, 0, 135-angle));
                    angle = 135;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 225-angle));
                    angle = 225;
                }
            }
            else if (x2 > 0)
            {
                transform.Rotate(new Vector3(0, 0, 90-angle));
                angle = 90;
            }
            else if (x2 < 0)
            {
                transform.Rotate(new Vector3(0, 0, -90-angle));
                angle = -90;
            }
            */
            /*
            if (x != 0 || x2 != 0)
                anim.SetTrigger("Walk");
            else
                anim.SetTrigger("Stay");
            */
            transform.Translate(Vector3.up * 60f * Time.fixedDeltaTime * (float)x * Screen.height/600);
            transform.Translate(Vector3.right * 60f * Time.fixedDeltaTime * (float)x2  * Screen.width/800);
    }

    [Command(requiresAuthority = false)]
	private void CollisionServer(double x4, double y4) => CollisionClient(x4, y4);

	[ClientRpc]
	private void CollisionClient(double x4, double y4)
    {
        double x = collision.gameObject.transform.position.x;
        double y = collision.gameObject.transform.position.y;
        if  (collision.gameObject.name ==  "mur_bas")  
        {
            transform.Translate(new Vector2(0,1) * 30 * Screen.height/600);
        }
        else if  (collision.gameObject.name ==  "mur_haut")  
        {
            transform.Translate(new Vector2(0,-1) * 30 * Screen.height/600);
        }
        else if  (collision.gameObject.name ==  "mur_droite")  
        {
            transform.Translate(new Vector2(-1,0) * 30 * Screen.width/800);
        }
        else if  (collision.gameObject.name ==  "mur_gauche" )  
        {
            transform.Translate(new Vector2(1,0) * 30 * Screen.width/800);
        }
        else
        {
            double x2 = Joueur.transform.position.x;
            double y2 = Joueur.transform.position.y;
            if (y4 < 0)
                transform.Translate(new Vector2(0,1) * 5 * Screen.height/600);
            if (y4 > 0)
                transform.Translate(new Vector2(0,-1) * 5 * Screen.height/600);
            if (x4 < 0)
                transform.Translate(new Vector2(1,0) * 5 * Screen.width/800);
            if (x4 > 0)
                transform.Translate(new Vector2(-1,0) * 5 * Screen.width/800);
                
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        timecol = Gamer1.TimeLeft;
        if (NetworkServer.active)
            CollisionClient(last_x, last_y);
        else
            CollisionServer(last_x, last_y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerClass gamer;
        if (NetworkServer.active)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        double x = Joueur.transform.position.x;
		double x2 = Screen.width/2;
        if (NetworkServer.active == (x <= x2))
        {
            if (other.gameObject.CompareTag("amelioration1") && amelioration1)
            {
                if (gamer._money < 2500)
				    TextActionJoueur1.action.color = Color.red;
			    else
				    TextActionJoueur1.action.color = Color.green;
                TextActionJoueur1.action.text = gamer.materiel[1] + " : 2500 $";
                move = false;
            }
            else if (other.gameObject.CompareTag("amelioration2") && amelioration2)
            {
                if (gamer._money < 2500)
				    TextActionJoueur1.action.color = Color.red;
			    else
				    TextActionJoueur1.action.color = Color.green;
                TextActionJoueur1.action.text = gamer.materiel[2] + " : 2500 $";
                move = false;
            }
            else if (other.gameObject.CompareTag("item1"))
            {      
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[0]];
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[0] + $" : {n}";
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
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[1] + $" : {n}";
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
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[2] + $" : {n}";
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
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[3] + $" : {n}";
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
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[4] + $" : {n}";
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
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[5] + $" : {n}";
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
                    TextActionJoueur1.action.text = "Quantité de " + gamer._items[6] + $" : {n}";
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
                    TextActionJoueur1.action.text = "Quantité de " + gamer._items[7] + $" : {n}";
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
                    TextActionJoueur1.action.text = "Quantité de " + gamer._items[8] + $" : {n}";
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
                    TextActionJoueur1.action.text = "Quantité de " + gamer._items[9] + $" : {n}";
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
                    TextActionJoueur1.action.text = "Quantité de " + gamer._items[10] + $" : {n}";
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
                    TextActionJoueur1.action.text = "Quantité de " + gamer._items[11] + $" : {n}";
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
                TextActionJoueur1.action.text = $"< Nombre d'employés : {gamer._stat["Employé"]} >";
                TextActionJoueur1.action.color = Color.green;
            }
            else if (other.gameObject.CompareTag("promotion"))
            {
                move = false;
                if (gamer.materiel[0] != "acheté")
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
            else if (other.gameObject.CompareTag("commercial"))
            {
                TextActionJoueur1.action.text = "Cartes de fidélité : 100 $";
            }
        }
    }

    public  void ChangementText(int n, bool verif)
    {
        PlayerClass gamer;
        if (verif)
            gamer = Gamer1;
        else
            gamer = Gamer2;
        if ((TextActionJoueur1.action.text.Contains("Finir") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("magasins") && Input.GetKeyDown(KeyCode.UpArrow)))
            TextActionJoueur1.action.text = $"< Salaire : {gamer._stat["Salaire"]} $ >";
        else if ((TextActionJoueur1.action.text.Contains("Salaire") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Prime") && Input.GetKeyDown(KeyCode.UpArrow)))
            TextActionJoueur1.action.text = $"< Nombre de magasins : {gamer._stat["Magasin"]} >";
        else if ((TextActionJoueur1.action.text.Contains("magasins") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("employés :") && Input.GetKeyDown(KeyCode.UpArrow)))
            TextActionJoueur1.action.text = "Prime : 1000 $/employé";
        else if ((TextActionJoueur1.action.text.Contains("Publicité") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Cadeaux") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Cartes de fidélité : 100 $";
        }
        else if ((TextActionJoueur1.action.text.Contains("Cartes") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Publicité") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Cadeaux : 500 $";
        }
        else if ((TextActionJoueur1.action.text.Contains("Cadeaux") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Cartes") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Publicité : 1000 $";
        }
        else if ((TextActionJoueur1.action.text.Contains("Prime") && Input.GetKeyDown(KeyCode.DownArrow)) ||(TextActionJoueur1.action.text.Contains("Finir") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = $"< Nombre d'employés : {gamer._stat["Employé"]} >";
            TextActionJoueur1.action.color = Color.green;
        }
        else if ((TextActionJoueur1.action.text.Contains("employés :") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Salaire") && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            TextActionJoueur1.action.text = "Finir son tour";
            TextActionJoueur1.action.color = Color.green;
        }
        else if (gamer._items[n] != "NaN")
        {
            (int m, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[n]];
            if ((TextActionJoueur1.action.text.Contains("Quantité de") 
                && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("de niveau") && Input.GetKeyDown(KeyCode.UpArrow)))
                    TextActionJoueur1.action.text = "< Prix de " + gamer._items[n] + $" : {j} $ >";
            else if ((TextActionJoueur1.action.text.Contains("Prix de") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Quantité de") && Input.GetKeyDown(KeyCode.UpArrow)))
                TextActionJoueur1.action.text = gamer._items[n] + " de niveau " +$"{d}"+$" : {50*Math.Pow(d, 2)} $";
            else if (
            (TextActionJoueur1.action.text.Contains("de niveau") && Input.GetKeyDown(KeyCode.DownArrow)) || (TextActionJoueur1.action.text.Contains("Prix de") && Input.GetKeyDown(KeyCode.UpArrow)))
            {
                TextActionJoueur1.action.text = "Quantité de " + gamer._items[n] + $" : {m}";

            }
        }
            
    }
}
