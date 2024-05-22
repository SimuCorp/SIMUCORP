using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class chat : MonoBehaviour, message
{
    public InputField inputField;
    public GameObject Message;
    public GameObject Content;

    public void SendMessage()
    {
        GetComponent<PhotonView>().RPC("GetMessage", RpcTarget.All, inputField.text);
    }
    [PunRPC]
    public void GetMessage(string message)
    {
        
        GameObject M = Instantiate(Message, Vector3.zero, Quaternion.identity, Content.transform);
        M.GetComponent<Message>().My= message;
    }
    
    
}
