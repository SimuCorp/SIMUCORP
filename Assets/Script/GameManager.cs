using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ButtonExitCommercial;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (ButtonExitCommercial.changement)
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonExitCommercial.changement)
            Destroy(this);
    }
}
