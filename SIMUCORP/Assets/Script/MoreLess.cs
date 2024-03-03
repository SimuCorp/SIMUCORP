using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Mirror;
using static System.Math;
using static MoneyCount;
using static TextEmploye;
using static TextMagasin;
using static TextSalaire;

public class MoreLess : NetworkBehaviour 
{
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
}
