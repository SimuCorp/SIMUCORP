using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static PlayerScript;
public class JoinClient : MonoBehaviour
{

    [Header("UI")]
    [SerializeField] private GameObject landingPagePanel = null;
    [SerializeField] private Button joinButton = null;
    [SerializeField] private Button ButtonPart = null;

    [SerializeField] private NetworkDiscoveryCustom networkdiscovery = null;

    public Animator fondu;
    public void OpenJoin(bool b)
    {
        joinButton.interactable = false;
        ButtonPart.interactable = false;
        Gamer1 = new Primeur("Primeur");
	    Gamer2 = new Boucherie("Boucher");
        networkdiscovery.ConnectClient();
        StartCoroutine("attend");

    }

    IEnumerator attend()
    {
        yield return new WaitForSeconds(9);
        landingPagePanel.SetActive(true);
        joinButton.interactable = true;
        ButtonPart.interactable = true;
        yield return new WaitForSeconds(3);
        landingPagePanel.SetActive(false);
        
    }
    

    private void HandleClientConnected()
    {
        joinButton.interactable = true;

        gameObject.SetActive(false);
        landingPagePanel.SetActive(false);
    }

    private void HandleClientDisconnected()
    {
        joinButton.interactable = true;
    }
}
