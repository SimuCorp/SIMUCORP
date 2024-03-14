using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static System.Math;
using static MoneyCount;
using static TourCount;

public class PlayerScript : NetworkBehaviour 
{
    [SerializeField]
    private float speed; //vitesse de déplacement
 
    void FixedUpdate () 
    {
        if(this.isLocalPlayer) 
        {
            float hMove = Input.GetAxis("Horizontal");
            float VMove = Input.GetAxis("Vertical"); 
            GetComponent<Rigidbody>().velocity = new Vector3(hMove * speed, VMove * speed,0.0f);
        }
    }

	public void Exit()
    {
        SceneManager.LoadScene("ScenePrincipale");
    }

    public void ExitGestion()
    {
        SceneManager.LoadScene("ActionGestion");
    }

	public void ExitPrix1()
    {
        SceneManager.LoadScene("ActionPrix2");
    }

	public void ExitPrix2()
    {
        SceneManager.LoadScene("ActionPrix3");
    }
    
	public void ExitPrix3()
    {
        SceneManager.LoadScene("ActionPrix4");
    }
	
	public void ExitPrix4()
    {
        SceneManager.LoadScene("ActionPrix1");
    }
	
	public void ExitApro1()
	{
		SceneManager.LoadScene("ActionApro2");
	}

	public void ExitApro2()
	{
		SceneManager.LoadScene("ActionApro3");
	}

	public void ExitApro3()
	{
		SceneManager.LoadScene("ActionApro4");
	}

	public void ExitApro4()
	{
		SceneManager.LoadScene("ActionApro1");
	}
	
	public void ExitQuali1()
	{
		SceneManager.LoadScene("ActionQuali2");
	}

	public void ExitQuali2()
	{
		SceneManager.LoadScene("ActionQuali3");
	}

	public void ExitQuali3()
	{
		SceneManager.LoadScene("ActionQuali4");
	}

	public void ExitQuali4()
	{
		SceneManager.LoadScene("ActionQuali1");
	}
	
	public void ExitMateriel1()
	{
		int i = 0;
		int length = Gamer1._items.Count;

		while (i < length && Gamer1._items[i] == "done")
			++i;
		if (i < length)
			SceneManager.LoadScene("ActionMateriel2");
	}

	public void ExitMateriel2()
	{
		SceneManager.LoadScene("ActionMateriel3");
	}

	public void ExitMateriel3()
	{
		SceneManager.LoadScene("ActionMateriel1");
	}

	public void ExitAccueil()
	{
		SceneManager.LoadScene("ChoixTour");
	}

	public void Simple()
	{
		SceneManager.LoadScene("NonPerissable");
	}

	public void Difficile()
	{
		SceneManager.LoadScene("Perissable");
	}

	public void ExitPrimeur()
	{
		if (!multijoueur && this.isServer)
			Gamer1 = new Primeur("Primeur");
		else
		{
			Gamer2 = new Primeur("Primeur");
			multijoueur = true;
		}	
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitBoucherie()
	{
		if (!multijoueur && this.isServer)
			Gamer1 = new Boucherie("Boucher");
		else
		{
			Gamer2 = new Boucherie("Boucher");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitLibraire()
	{
		if (!multijoueur && this.isServer)
			Gamer1 = new Libraire("Libraire");
		else
		{
			Gamer2 = new Libraire("Libraire");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitCoiffeur()
	{
		if (!multijoueur && this.isServer)
			Gamer1 = new Coiffeur("Coiffeur");
		else
		{
			Gamer2 = new Coiffeur("Coiffeur");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitPoisson()
	{
		if (!multijoueur || this.isServer)
			Gamer1 = new Poissonier("Poissonier");
		else
		{
			Gamer2 = new Poissonier("Poissonier");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitBijouterie()
	{
		if (!multijoueur || this.isServer)
			Gamer1 = new Bijouterie("Bijoutier");
		else
		{
			Gamer2 = new Bijouterie("Bijoutier");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitVetement()
	{
		if (!multijoueur || this.isServer)
			Gamer1 = new Pret_a_porter("Prêt à porter");
		else
		{
			Gamer2 = new Pret_a_porter("Prêt à porter");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitFleur()
	{
		if (!multijoueur || this.isServer)
			Gamer1 = new Fleuriste("Fleuriste");
		else
		{
			Gamer2 = new Fleuriste("Fleuriste");
			multijoueur = true;
		}
		TurnValues = 1;
		SceneManager.LoadScene("ScenePrincipale");
	}

	public void ExitCourte()
	{
		MaxTurn = 13;
		SceneManager.LoadScene("ChoixDifficulté");
	}

	public void ExitMoyenne()
	{
		MaxTurn = 26;
		SceneManager.LoadScene("ChoixDifficulté");
	}
		
	public void ExitLongue()
	{
		MaxTurn = 52;
		SceneManager.LoadScene("ChoixDifficulté");
	}

	public void Retour()
	{
		SceneManager.LoadScene("EcranAccueil");
	}

	public void More(double value)
    {
        ++value;
    }
    
    public void Less(double value)
    {
		if (value > 0)
        	--value;
    }

    public void MoreEmploy()
    {
        ++TextEmploye.n;
    }
    
    public void LessEmploy()
    {
		if (TextEmploye.n > 0)
        	--TextEmploye.n;
    }

	public void MoreMagasin()
    {
        ++TextMagasin.n;
    }
    
    public void LessMagasin()
    {
		if (TextMagasin.n > 1)
        	--TextMagasin.n;
    }

	public void MoreSalaire()
    {
        ++TextSalaire.n;
    }
    
    public void LessSalaire()
    {
		if (TextSalaire.n > 1399)
        	--TextSalaire.n;
    }

	public void MorePrice1()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 1)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice1()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 1)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice2()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 2)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice2()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 2)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice3()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 3)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice3()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 3)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice4()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 4)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice4()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 4)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice5()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 5)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice5()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 5)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice6()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 6)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice6()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 6)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice7()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 7)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice7()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 7)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice8()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 8)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice8()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 8)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice9()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 9)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice9()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 9)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice10()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 10)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice10()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 10)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice11()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 11)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice11()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 11)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}
	
	public void MorePrice12()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 12)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		gamer._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice12()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		string res = "";
		int i1 = 1;
		foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 12)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		gamer._marchandise[res] = (i, Round(j-0.01, 2), b, d, k);
	}

	public void MoreApro1()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 1)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[0]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More1 += 5;
		}
	}

	public void MoreApro2()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 2)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[1]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More2 += 5;
		}
	}

	public void MoreApro3()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 3)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[2]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More3 += 5;
		}
	}

	public void MoreApro4()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 4)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[3]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More4 += 5;
		}
	}

	public void MoreApro5()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 5)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[4]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More5 += 5;
		}
	}

	public void MoreApro6()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 6)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[5]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More6 += 5;
		}
	}

	public void MoreApro7()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 7)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[6]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More7 += 5;
		}
	}

	public void MoreApro8()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 8)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[7]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More8 += 5;
		}
	}

	public void MoreApro9()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 9)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[8]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More9 += 5;
		}
	}

	public void MoreApro10()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 10)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[9]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More10 += 5;
		}
	}

	public void MoreApro11()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 11)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[10]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More11 += 5;
		}
	}

	public void MoreApro12()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
        string res = "";
        foreach (string s in gamer._marchandise.Keys)
        {
            if (i1 == 12)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-gamer.prix[11]*5))
		{
			gamer._marchandise[res] = (i+5, j, b, d, k);
			gamer.More12 += 5;
		}
	}

	public void MoreQuali1()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 1)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali2()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 2)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}
	
	public void MoreQuali3()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 3)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali4()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 4)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali5()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 5)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali6()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 6)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali7()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 7)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali8()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 8)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali9()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 9)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali10()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 10)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali11()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 11)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali12()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		int i1 = 1;
		string res = "";
		foreach (string s in gamer._marchandise.Keys)
		{
			if (i1 == 12)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= gamer._marchandise[res];
		if (b && gamer.AddMoney(-50*Pow(d, 2)))
		{
			gamer._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void DoAct1()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer.materiel[0] == "done")
        {
			gamer.promo = !gamer.promo;
			if (gamer.promo)
				gamer._stat["Attracivité"] *= 1.33;
			else
				gamer._stat["Attracivité"] /= 1.33;
		}
    }

    public void DoAct12()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer._stat["Employé"] > TextEmploye.n)
		{
			if (!gamer.AddMoney(-700*(gamer._stat["Employé"] - TextEmploye.n)))
				SceneManager.LoadScene("GameOver");
		}
        gamer._stat["Employé"] = TextEmploye.n;
    }
	
	public void DoAct2()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        gamer._stat["Attracivité"] += 5;
        gamer.AddMoney(-1000);
    }

	public void DoAct22()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		gamer._stat["Qualité"] += (gamer._stat["Salaire"] - TextSalaire.n)/50; 
		gamer._stat["Salaire"] = TextSalaire.n;
	}

	public void DoAct3()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        gamer._stat["Attracivité"] += 0.5;
        gamer.AddMoney(-100);
    }

    public void DoAct32()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        double n = TextMagasin.n;
        double n1 = gamer._stat["Magasin"];
        bool b = true;
        if (TextMagasin.n - 1 <= gamer._stat["Employé"])
        {
            if (n1 - n > 0)
                b = gamer.AddMoney(2500 * (n1 - n));
            else if (n1 - n < 0)
                b = gamer.AddMoney(5000 * (n1 - n));
            if (b)
                gamer._stat["Magasin"] = n;
            else
                TextMagasin.n = gamer._stat["Magasin"];
        }
    }

	public void DoAct4()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        gamer._stat["Attracivité"] += 2.5;
        gamer.AddMoney(-500);
    }

	public void DoAct42()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if (gamer.AddMoney(-1000*gamer._stat["Employé"]) && gamer._stat["Employé"] != 0)
			gamer._stat["Qualité"] += 2*gamer._stat["Employé"];
	}

	public void Materiel1()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        if (gamer.materiel[0] != "done" && gamer.AddMoney(-200))
        {
           gamer.materiel[0] = "done";
           gamer._stat["Attracivité"] += 0.01;
        }
    }
   
   public void Materiel2()
   {
	  PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
      if (gamer.materiel[1] != "done" && gamer.AddMoney(-2500))
      {
         gamer.materiel[1] = "done";
         gamer._stat["Attracivité"] += 5;
      }
   }
   
   public void Materiel3()
   {
      PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
      if (gamer.materiel[2] != "done" && gamer.AddMoney(-2500))
      {
         gamer.materiel[2] = "done";
         gamer._stat["Attracivité"] += 5;
      }
   }

	public void Materiel5()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[0] != "done" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 7)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[0] = "done";
			gamer._items[6] = s;
		}
	}

	public void Materiel6()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[1] != "done" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 8)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[1] = "done";
			gamer._items[7] = s;
		}
	}

	public void Materiel7()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[2] != "done" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 9)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[2] = "done";
			gamer._items[8] = s;
		}
	}

	public void Materiel8()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[3] != "done" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 10)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[3] = "done";
			gamer._items[9] = s;
		}
	}

	public void Materiel9()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[4] != "done" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 11)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[4] = "done";
			gamer._items[10] = s;
		}
	}

	public void Materiel10()
	{
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
		if(gamer._missingitems[5] != "done" && gamer.AddMoney(-300))
		{
			int i = 1;
			int a = 0;
			double b = 0;
			bool c = false;
			double d = 0;
			int e = 0;
			string s = "";
			foreach(string res in gamer._marchandise.Keys)
			{
				if (i == 12)
				{
					(a, b, c, d, e) = gamer._marchandise[res];
					s = res;
				}
				++i;
			}
			gamer._marchandise[s] = (a, b, true, d, e);
			gamer._missingitems[5] = "done";
			gamer._items[11] = s;
		}
	}

	public void DoButtonPass()
    {
		PlayerClass gamer;
		if (isServer)
			gamer = Gamer1;
		else
			gamer = Gamer2;
        gamer._button = false;
        if (Gamer1._button == Gamer2._button)
        {
            CalCulus(Gamer1, "");
            CalCulus(Gamer2, "");
            CountdownScript.UpdateTimeButton(Gamer1);
        }
    }
}
