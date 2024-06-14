using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{

    [SerializeField] private GameObject Accueil;
    // Start is called before the first frame update
    void Start()
    {
        Accueil.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
