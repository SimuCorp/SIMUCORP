using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ButtonExitCommercial;
using Photon.Realtime;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerprefab;
    void Start()
    {
        PhotonNetwork.Instantiate(this.playerprefab.name,new Vector2(0,0), Quaternion.identity);
        if (ButtonExitCommercial.changement)
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        //ONLY TESTS
        if (Input.GetKeyDown(KeyCode.Escape))
            QuitAPP();
        if (ButtonExitCommercial.changement)
            Destroy(this);
    }
    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }
    public void QuitAPP()
    {
        Application.Quit();
    }
}
