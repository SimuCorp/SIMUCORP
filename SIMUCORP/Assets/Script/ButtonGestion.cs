using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static MoneyCount;
public class ButtonGestion : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField]
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("ActionGestion",  LoadSceneMode.Additive));
    }
    
}