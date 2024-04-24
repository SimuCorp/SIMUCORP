using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
using static ButtonExitCommercial;
using static PlayerScript;
public class ButtonCommercial : MonoBehaviour
{

	public void DoButtonCommercial()
	{
        Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionCommercial",  LoadSceneMode.Additive);
	}
    // Start is called before the first frame update
    [SerializeField]
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonCommercial());
    }
    
}
