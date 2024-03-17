using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;


    public class LobbyTopPanel : MonoBehaviour
    {
        public readonly string connectionStatusMessage = "    Connection Status: ";

        [Header("UI References")]
        public Text ConnectionStatusText;

        #region UNITY

        public void Update()
        {
            ConnectionStatusText.text = connectionStatusMessage + PhotonNetwork.NetworkClientState;
        }

        #endregion
    }
