using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static System.Math;
using static MoneyCount;
using static TourCount;
using static PlayerScript;
public class PathFindingAI : MonoBehaviour
{

    [SerializeField] static Transform ActualTarget;
    [SerializeField] Transform promo;
    [SerializeField] Transform caisse;
    [SerializeField] Transform commercial;
    [SerializeField] Transform amelioration1;
    [SerializeField] Transform amelioration2;
    [SerializeField] Transform Item1;
    [SerializeField] Transform Item2;
    [SerializeField] Transform Item3;
    [SerializeField] Transform Item4;
    [SerializeField] Transform Item5;
    [SerializeField] Transform Item6;
    [SerializeField] Transform Item7;
    [SerializeField] Transform Item8;
    [SerializeField] Transform Item9;
    [SerializeField] Transform Item10;
    [SerializeField] Transform Item11;
    [SerializeField] Transform Item12;
    [SerializeField] Transform Joueur;
    //NavMeshAgent agent;
    private static bool Perime;
    private static bool fin;
    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        //agent.updateRotation = false;
        //agent.updateUpAxis = false;
        ActualTarget = Item1;
        Perime = Gamer2 is Primeur || Gamer2 is Boucherie || Gamer2 is Fleuriste || Gamer2 is Poissonier;
        fin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamer1.TimeLeft >= 120)
            fin = false;
        else
        {
            double x = ActualTarget.position.x;
            double x2 = Joueur.position.x;
            double y = ActualTarget.position.y;
            double y2 = Joueur.position.y;
            if (x < x2)
            {
                transform.Translate(Vector3.right * 30f * Time.fixedDeltaTime * -0.1f);
            }
            if (x > x2)
            {
                transform.Translate(Vector3.right * 30f * Time.fixedDeltaTime * 0.1f);
            }
            if (y < y2)
                transform.Translate(Vector3.up * 30f * Time.fixedDeltaTime * -1);
            if (y > y2)
                transform.Translate(Vector3.up * 30f * Time.fixedDeltaTime * 1);
        }
        /*
        if (Gamer1.TimeLeft < 120 && !fin)
            agent.SetDestination(ActualTarget.position);
        else
            agent.SetDestination(Joueur.position);
        */
    }
    public static void Achete(int i)
    {

	    PlayerClass metier = Gamer2;
		if (metier._items[i] != "NaN")
		{
			double nb_magasin = metier._stat["Magasin"];
			(int Quantity, double price, bool possible, double promo, int tour) = metier._marchandise[metier._items[i]];
			if (tour == 3)
				Perime = true;
			bool b;
			if (Perime)
				b = (Quantity <= 100 || (((i == 0 && metier.Perime1[0] <= Quantity / 2) ||
					                (i == 1 && metier.Perime2[0] <= Quantity / 2) ||
					                (i == 2 && metier.Perime3[0] <= Quantity / 2) ||
					                (i == 3 && metier.Perime4[0] <= Quantity / 2) ||
					                (i == 4 && metier.Perime5[0] <= Quantity / 2) ||
					                (i == 5 && metier.Perime6[0] <= Quantity / 2) ||
					                (i == 6 && metier.Perime7[0] <= Quantity / 2) ||
					                (i == 7 && metier.Perime8[0] <= Quantity / 2) ||
					                (i == 8 && metier.Perime9[0] <= Quantity / 2) ||
					                (i == 9 && metier.Perime10[0] <= Quantity / 2) ||
					                (i == 10 && metier.Perime11[0] <= Quantity / 2) ||
					                (i == 11 && metier.Perime12[0] <= Quantity / 2)) && TurnValues >= 3));
			else
				b = ((price <= 2 && Quantity < 100*nb_magasin) || (price <= 10 && Quantity < 50*nb_magasin) ||
					(price <= 25 && Quantity < 25*nb_magasin) || (price <= 50 && Quantity < 10*nb_magasin) ||
					(price <= 100 && Quantity < 4*nb_magasin) || (price > 100 && Quantity < nb_magasin));
			if (b)
			{
				if ((price <= 2 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 10 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 25 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 50 && metier.AddMoney(-metier.prix[i]*5*nb_magasin)) || (price <= 100 && metier.AddMoney(-metier.prix[i]*4*nb_magasin)) || (price > 100 && metier.AddMoney(-metier.prix[i]*nb_magasin)))
				{
					int j = 0;
					if (price <= 2)
						j = 5*(int)nb_magasin;
					else if (price <= 10)
						j = 5*(int)nb_magasin;
					else if (price <= 25)
						j = 5*(int)nb_magasin;
					else if (price <= 50)
						j = 5*(int)nb_magasin;
					else if (price <= 100)
						j = 4*(int)nb_magasin;
					else
						j = (int)nb_magasin;
					if (i == 0)
						metier.More1 += j;
					else if (i == 1)
						metier.More2 += j;
					else if (i == 2)
						metier.More3 += j;
					else if (i == 3)
						metier.More4 += j;
					else if (i == 4)
						metier.More5 += j;
					else if (i == 5)
						metier.More6 += j;
					else if (i == 6)
						metier.More7 += j;
					else if (i == 7)
						metier.More8 += j;
					else if (i == 8)
						metier.More9 += j;
					else if (i == 9)
						metier.More10 += j;
					else if (i == 10)
						metier.More11 += j;
					else
						metier.More12 += j;
					Quantity += j;
					metier._marchandise[metier._items[i]] = (Quantity, price, possible, promo, tour);
				}
			}
		}
		
	}
	public static void LevelUp(int i)
    {
        PlayerClass metier = Gamer2;
		if (metier._items[i] != "NaN")
		{
			(int Quantity, double price, bool possible, double level, int tour) = metier._marchandise[metier._items[i]];
			double prix = 50*Pow(level, 2);
			if (metier._money >= 2*prix)
			{
				metier.AddMoney(-prix);
				++level;
			}
			metier._marchandise[metier._items[i]] = (Quantity, price, possible, level, tour);
		}

	}
	public static void NewProduct(int i)
    {
        PlayerClass metier = Gamer2;
		if (metier._items[i] == "NaN" && metier._money >= 600)
		{
				metier.AddMoney(-300);
				metier._items[i] = metier._missingitems[i-6];
				metier._missingitems[i-6] = "acheté";
				(int a, double b, bool c, double d,int e) = metier._marchandise[metier._items[i]];
				metier._marchandise[metier._items[i]] = (a, b, true, d, e);
		}
	
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerClass gamer = Gamer2;
        if (other.gameObject.CompareTag("amelioration1"))
        {
            if (gamer._money > 5_000 && gamer.materiel[1] != "acheté" && gamer.AddMoney(-2500))
            {
                gamer.materiel[1] = "acheté";
				gamer._stat["Attractivité"] += 5;
            }
            ActualTarget = amelioration2;
        }
        else if (other.gameObject.CompareTag("amelioration2"))
        {

            if (gamer._money > 5_000 && gamer.materiel[2] != "acheté" && gamer.AddMoney(-2500))
            {
                gamer.materiel[2] = "acheté";
				gamer._stat["Attractivité"] += 5;
            }
            ActualTarget = caisse;
        }
        else if (other.gameObject.CompareTag("item1"))
        {      
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[0]];
            for (int i = 0; i < 12; ++i)
            {
                Achete(0);
                LevelUp(0);
            }
           
            ActualTarget = Item2;

        }
        else if (other.gameObject.CompareTag("item2"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[1]];
            for (int i = 0; i < 12; ++i)
            {
                Achete(1);
                LevelUp(1);
            }
            ActualTarget = Item3;
  

        }
        else if (other.gameObject.CompareTag("item3"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[2]];
            for (int i = 0; i < 12; ++i)
            {
                Achete(2);
                LevelUp(2);
            }
            ActualTarget = Item4;
          
        }
        else if (other.gameObject.CompareTag("item4"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[3]];
            for (int i = 0; i < 12; ++i)
            {
                Achete(3);
                LevelUp(3);
            }
        
            ActualTarget = Item5;
        }
        else if (other.gameObject.CompareTag("item5"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[4]];

            for (int i = 0; i < 12; ++i)
            {
                Achete(4);
                LevelUp(4);
            }
            ActualTarget = Item6;

        }
        else if (other.gameObject.CompareTag("item6"))
        {
            (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[5]];
            for (int i = 0; i < 12; ++i)
            {
                Achete(5);
                LevelUp(5);
            }
            ActualTarget = Item7;
 

        }
        else if (other.gameObject.CompareTag("item7"))
        {
    
            if(gamer._items[6] == "NaN")
            {
                NewProduct(6);
     
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[6]];
                for (int i = 0; i < 12; ++i)
                {
                    Achete(6);
                    LevelUp(6);
                 }
           
            }
            ActualTarget = Item8;
        }
        else if (other.gameObject.CompareTag("item8"))
        {
  
      
            if(gamer._items[7] == "NaN")
            {
                NewProduct(7);
      
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[7]];
                for (int i = 0; i < 12; ++i)
                {
                    Achete(7);
                    LevelUp(7);
                }
       
  
            }
            ActualTarget = Item9;
        }
        else if (other.gameObject.CompareTag("item9"))
        {
  
    
            if(gamer._items[8] == "NaN")
            {
    
                NewProduct(8);
            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[8]];
                for (int i = 0; i < 12; ++i)
                {
                    Achete(8);
                    LevelUp(8);
                }
             

            }
            ActualTarget = Item10;
        }
        else if (other.gameObject.CompareTag("item10"))
        {
        
    
            if(gamer._items[9] == "NaN")
            {
                NewProduct(9);

            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[9]];
                for (int i = 0; i < 12; ++i)
                {
                    Achete(9);
                    LevelUp(9);
                }
            

            }
            ActualTarget = Item11;
        }
        else if (other.gameObject.CompareTag("item11"))
        {
        
            if(gamer._items[10] == "NaN")
            {
    
                NewProduct(10);

            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[10]];
                for (int i = 0; i < 12; ++i)
                {
                    Achete(10);
                    LevelUp(10);
                }
             

            }
            ActualTarget = Item12;
        }
        else if (other.gameObject.CompareTag("item12"))
        {
      
   
            if(gamer._items[11] == "NaN")
            {
                NewProduct(11);

            }
            else
            {
                (int n, double j, bool b, double d, int k)= gamer._marchandise[gamer._items[11]];
                for (int i = 0; i < 12; ++i)
                {
                    Achete(11);
                    LevelUp(11);
                }    
            }
            ActualTarget = commercial;
        }
        else if (other.gameObject.CompareTag("Caisse"))
        {
            if (gamer._money > 7_500 && TurnValues % 4 >= 1)
	        {
		        ++gamer._stat["Magasin"];
		        ++gamer._stat["Employé"];
		        gamer.AddMoney(-5000);
	        }
			else if (gamer._stat["Magasin"] > 1 && TurnValues % 4 >= 1 && gamer._money < 1399*gamer._stat["Employé"])
			{
				--gamer._stat["Magasin"];
		        --gamer._stat["Employé"];
				gamer.AddMoney(1800);
			}
            else if (gamer._money*2 > 1000*gamer._stat["Employé"] && gamer.AddMoney(-1000*gamer._stat["Employé"]) && gamer._stat["Employé"] != 0)
				gamer._stat["Qualité"] += 2*gamer._stat["Employé"];
            ActualTarget = promo;
        }
        else if (other.gameObject.CompareTag("promotion"))
        {
            if (gamer.materiel[0] != "acheté" && gamer.AddMoney(-300))
			{
				gamer.materiel[0] = "acheté";
				gamer.promo = true;
				gamer._stat["Attractivité"] *= 1.33;
			}
            ActualTarget = Item1;
           
        }
        else if (other.gameObject.CompareTag("commercial"))
        {
            if (gamer._stat["Attractivité"] < 80 && gamer._money > 5_000 && gamer.AddMoney(-1000))
			{
				gamer._stat["Attractivité"] += 5;
			}
			else if (gamer._stat["Attractivité"] < 80 && gamer._money > 2500 && gamer.AddMoney(-500))
				gamer._stat["Attractivité"] += 2.5;
			else if (gamer._stat["Attractivité"] < 80 && gamer._money > 1500 && gamer.AddMoney(-100))
				gamer._stat["Attractivité"] += 0.5;
            CalCulus(gamer, "");
            fin = true;
            ActualTarget = amelioration1;
        }
    }
}
