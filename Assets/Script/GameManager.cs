using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static ButtonExitCommercial;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public Text InfoText;
    public const string PLAYER_READY = "IsPlayerReady";
    public const string PLAYER_LOADED_LEVEL = "PlayerLoadedLevel";
    public static Color GetColor(int colorChoice)
    {
        switch (colorChoice)
        {
            case 0: return Color.red;
            case 1: return Color.green;
            case 2: return Color.blue;
            case 3: return Color.yellow;
            case 4: return Color.cyan;
            case 5: return Color.grey;
            case 6: return Color.magenta;
            case 7: return Color.white;
        }

        return Color.black;
    }
    
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
    private IEnumerator EndOfGame(string winner, int score)
    {
        float timer = 5.0f;

        while (timer > 0.0f)
        {
            InfoText.text = string.Format("Player {0} won with {1} points.\n\n\nReturning to login screen in {2} seconds.", winner, score, timer.ToString("n2"));

            yield return new WaitForEndOfFrame();

            timer -= Time.deltaTime;
        }

        PhotonNetwork.LeaveRoom();
    }
    
}
