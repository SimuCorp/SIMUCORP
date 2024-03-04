using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
public class ButtonCommercial : MonoBehaviour
{

	public void DoButtonCommercial()
	{
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
