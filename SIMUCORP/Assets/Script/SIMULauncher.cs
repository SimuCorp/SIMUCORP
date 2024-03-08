using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;


public class Launcher : MonoBehaviourPunCallbacks
{
	public Text feedbackText; 
    public Button btn;
	bool isConnected; 
	private byte maxPlayersPerRoom = 4;
    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }
	string gameVersion = "1";
	public void Connect()
	{
		
		feedbackText.text = "";
		isConnected = true;

 		//btn.interactable = false;

		
		// we check if we are connected or not, we join if we are , else we initiate the connection to the server.
		if (PhotonNetwork.IsConnected)
		{
			LogFeedback("Joining Room...");
			
			PhotonNetwork.JoinRandomRoom();
		}
		else
		{

			LogFeedback("Connecting...");

			// #Critical, we must first and foremost connect to Photon Online Server.
			PhotonNetwork.ConnectUsingSettings();
			PhotonNetwork.GameVersion = this.gameVersion;
		}
	}
	void LogFeedback(string message)
	{
		// we do not assume there is a feedbackText defined.
		if (feedbackText == null)
		{
			return;
		}

		// add new messages as a new line and at the bottom of the log.
		feedbackText.text += System.Environment.NewLine + message;
	}
	public override void OnConnectedToMaster()
	{
		
		if (isConnected)
		{
			LogFeedback("OnConnectedToMaster: Next -> try to Join Random Room");
			Debug.Log("PUN Basics Tutorial/Launcher: OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room.\n Calling: PhotonNetwork.JoinRandomRoom(); Operation will fail if no room found");

			// #Critical: The first we try to do is to join a potential existing room. If there is, good, else, we'll be called back with OnJoinRandomFailed()
			PhotonNetwork.JoinRandomRoom();
		}
	}
	public override void OnJoinRandomFailed(short returnCode, string message)
	{
		LogFeedback("<Color=Red>OnJoinRandomFailed</Color>: Next -> Create a new Room");
		Debug.Log("PUN Basics Tutorial/Launcher:OnJoinRandomFailed() was called by PUN. No random room available, so we create one.\nCalling: PhotonNetwork.CreateRoom");

		// #Critical: we failed to join a random room, maybe none exists or they are all full. No worries, we create a new room.
		PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = this.maxPlayersPerRoom });
	}
	public override void OnDisconnected(DisconnectCause cause)
	{
		LogFeedback("<Color=Red>OnDisconnected</Color> " + cause);
		Debug.LogError("PUN Basics Tutorial/Launcher:Disconnected");


		isConnected = false;
		//btn.interactable = true;


	}
	public override void OnJoinedRoom()
	{
		LogFeedback("<Color=Green>OnJoinedRoom</Color> with " + PhotonNetwork.CurrentRoom.PlayerCount + " Player(s)");
		Debug.Log("PUN Basics Tutorial/Launcher: OnJoinedRoom() called by PUN. Now this client is in a room.\nFrom here on, your game would be running.");

		// #Critical: We only load if we are the first player, else we rely on  PhotonNetwork.AutomaticallySyncScene to sync our instance scene.
		if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
		{
			Debug.Log("We load the 'ScenePrincipale' ");

			// #Critical
			// Load the Room Level. 
			PhotonNetwork.LoadLevel("ScenePrincipale");

		}
	}
	public void solo()
    {
		
		SceneManager.LoadScene("ChoixTour");
	
	}
}
 