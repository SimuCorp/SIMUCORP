using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cinématique : MonoBehaviour
{
    IEnumerator deb()
    {
        yield return new WaitForSeconds(113);
        Cursor.visible = true;
        SceneManager.LoadScene("Lobby");
    }
    void Start()
    {
        Cursor.visible = false;
        StartCoroutine("deb");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Cursor.visible = true;
            SceneManager.LoadScene("Lobby");
        }
    }
}
