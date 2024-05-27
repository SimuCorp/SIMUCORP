using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerScript;

public class MenuHost : MonoBehaviour
{
    [Header("UI")]
    public Button button;
    [SerializeField] private Button b2 = null;

    public Animator fondu;
    [SerializeField] private NetworkDiscoveryCustom networkdiscovery = null;
    [SerializeField] private GameObject landingPagePanel = null;
    void Start()
    {
        button = GetComponent<Button>();
    }
    IEnumerator attend()
    {
        fondu.Play("fin_tour");
        yield return new WaitForSeconds(6);
        button.interactable = true;
        b2.interactable = true;
    }

    IEnumerator attend2()
    {
        yield return new WaitForSeconds(3);
        landingPagePanel.SetActive(false);
    }
    public void HostLobby()
    {
        StartCoroutine("attend");
        button.interactable = false;
        b2.interactable = false;
        try
        {
            networkdiscovery.ConnectServer();      
        }
        catch
        {
            landingPagePanel.SetActive(true);
            StartCoroutine("attend2");
        }
        Gamer1 = new Primeur("Primeur");
        Gamer2 = new Boucherie("Boucher");
    }
}
