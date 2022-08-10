using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        Debug.Log("Is Connecting to the server");
        PhotonNetwork.ConnectUsingSettings();   
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Conntected to Server");
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected from the server for reason: "+cause.ToString());
    }
}
