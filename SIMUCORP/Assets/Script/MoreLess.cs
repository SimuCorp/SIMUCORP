using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static MoneyCount;
using static TextEmploye;
using static TextMagasin;
using static TextSalaire;

public class MoreLess : MonoBehaviour
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
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 1)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice1()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 1)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice2()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 2)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice2()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 2)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice3()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 3)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice3()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 3)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice4()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 4)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice4()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 4)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice5()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 5)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice5()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 5)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice6()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 6)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice6()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 6)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice7()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 7)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice7()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 7)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice8()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 8)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice8()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 8)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice9()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 9)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice9()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 9)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice10()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 10)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice10()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 10)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MorePrice11()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 11)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice11()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 11)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}
	
	public void MorePrice12()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 12)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		Gamer1._marchandise[res] = (i, j+0.01, b, d, k);
	}

	public void LessPrice12()
	{
		string res = "";
		int i1 = 1;
		foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 12)
            {
                res = s;
                break;
            }

            ++i1;
        }

        (int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (j == 0.01)
			j += 0.01;
		Gamer1._marchandise[res] = (i, Math.Round(j-0.01, 2), b, d, k);
	}

	public void MoreApro1()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 1)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[0]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro2()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 2)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[1]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro3()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 3)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[2]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro4()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 4)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[3]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro5()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 5)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[4]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro6()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 6)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[5]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro7()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 7)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[6]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro8()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 8)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[7]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro9()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 9)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[8]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro10()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 10)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[9]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro11()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 11)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[10]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreApro12()
	{
		int i1 = 1;
        string res = "";
        foreach (string s in Gamer1._marchandise.Keys)
        {
            if (i1 == 12)
            {
                res = s;
                break;
            }

            ++i1;
        }
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-Gamer1.prix[11]*20))
		{
			Gamer1._marchandise[res] = (i+20, j, b, d, k);
		}
	}

	public void MoreQuali1()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 1)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali2()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 2)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}
	
	public void MoreQuali3()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 3)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali4()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 4)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali5()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 5)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali6()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 6)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali7()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 7)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali8()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 8)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali9()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 9)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali10()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 10)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali11()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 11)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}

	public void MoreQuali12()
	{
		int i1 = 1;
		string res = "";
		foreach (string s in Gamer1._marchandise.Keys)
		{
			if (i1 == 12)
			{
				res = s;
				break;
			}

			++i1;
		}
		(int i, double j, bool b, double d, int k)= Gamer1._marchandise[res];
		if (b && Gamer1.AddMoney(-50*Math.Pow(d, 2)))
		{
			Gamer1._marchandise[res] = (i, j, b, d+1, k);
		}
	}
}
