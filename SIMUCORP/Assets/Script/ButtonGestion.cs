using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
using static ButtonExitCommercial;
public class ButtonGestion : MonoBehaviour
{
    
       public void DoButtonGestion()
	{
        Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
        ++Gamer1.nbCount;
		SceneManager.LoadScene("ActionGestion",  LoadSceneMode.Additive);
	}
    // Start is called before the first frame update
    [SerializeField]
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => DoButtonGestion());
    }
    
}