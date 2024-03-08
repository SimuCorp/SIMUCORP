using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class Gamemanager1 : MonoBehaviour
{
    public GameObject playerprefab;
    void Start()
    {
        PhotonNetwork.Instantiate(this.playerprefab.name,new Vector2(0,0), Quaternion.identity);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            QuitAPP();
    }
    public void OnLeftRoom()
    {
        SceneManager.LoadScene("ChoixPartie");
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
