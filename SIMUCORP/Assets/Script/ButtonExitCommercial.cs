using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
public class ButtonExitCommercial : MonoBehaviour
{

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
}
