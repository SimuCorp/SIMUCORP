using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static MoneyCount;
using static PlayerScript;
public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider sLider;
    public Text TxtVolume;
    public static string scene = "EcranAccueil";

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sLider = GetComponent<Slider>();
        TxtVolume = GetComponent<Text>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            SceneManager.LoadScene("Réglage", LoadSceneMode.Additive);
        }
    }

    public void multi()
    {
        SceneManager.LoadScene("ChoixTour");
    }
    public void solo()
    {
        SceneManager.LoadScene("ChoixDIfficulté");
    }
    
    public void LastScene()
    {
        if (ButtonExitCommercial.changement2)
        {
            Gamer1.TimeLeft += (Gamer1.TimeLeft/Gamer1.nbCount);
            ++Gamer1.nbCount;
            SceneManager.LoadScene("ScenePrincipale",  LoadSceneMode.Additive);
        }
        else
        {
            SceneManager.LoadScene("EcranAccueil", LoadSceneMode.Additive);
        }
    }
    public void Qualité()
    {
        SceneManager.LoadScene("QUALITE");
    }
    public void play()
    {
        SceneManager.LoadScene("play");
    }
    public void VOlume()
    {
        SceneManager.LoadScene("VOL");
    }
    
    public void ReglageG()
    {
        SceneManager.LoadScene("ReglageG");
    }
    
    public void Quitter()
    {
        Application.Quit();
    }

    public void reso340p()
    {
        Screen.SetResolution(640, 360, true);
    }
    
    public void reso720p()
    {
        Screen.SetResolution(1280, 720, true);
    }
    public void reso4k()
    {
        Screen.SetResolution(3840, 2160, true);
    }
    public void reso1080p()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    
    public void Playmusique()
    {
        audioSource.volume = sLider.value;
    }
    public void Pause()
    {
        audioSource.volume = 0f;
    }
    public void SliderChanger()
    {
        audioSource.volume = sLider.value;
        TxtVolume.text = "Volume " + (audioSource.volume * 100).ToString("00") + "%";
    }
    
}