using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static MainMenu;
public class Credit : MonoBehaviour
{
    public Animator anim;
    IEnumerator pause()
	{
		yield return new WaitForSeconds(88);
        anim.Play("fin_tour");
        yield return new WaitForSeconds(1);
        MainMenu.Quitter();
        //SceneManager.LoadScene("Action1");
	}
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("pause");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
