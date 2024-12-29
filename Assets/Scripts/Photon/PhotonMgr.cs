using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;// 함수를 동기화 하기위함
using Photon.Realtime;

public partial class PhotonMgr : MonoBehaviourPunCallbacks//콜백
{
    public PhotonView PV;
    // Start is called before the first frame update
    void Awake()
    {
        //스태틱으로 연결
        DontDestroyOnLoad(this);

        PhotonNetwork.GameVersion = "1.0.0";//같은 버전만 가능
        PhotonNetwork.SendRate = 20;
        PhotonNetwork.SerializationRate = 10;

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnDisconnected(DisconnectCause cause)//실패했을경우
    {
        base.OnDisconnected(cause);
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        Debug.Log("OnJoinedLobby");
    }

    public void OnLobby()
    {
        PhotonNetwork.IsMessageQueueRunning = true;//큐방식으로 받겠다.
    }
}
