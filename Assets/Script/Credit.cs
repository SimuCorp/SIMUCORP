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
        Cursor.visible = true;
        MainMenu.Quitter();
        //SceneManager.LoadScene("Action1");
	}
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        StartCoroutine("pause");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Cursor.visible = true;
            MainMenu.Quitter();
        }
    }
}
