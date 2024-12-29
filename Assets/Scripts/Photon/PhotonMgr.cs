using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;// �Լ��� ����ȭ �ϱ�����
using Photon.Realtime;

public partial class PhotonMgr : MonoBehaviourPunCallbacks//�ݹ�
{
    public PhotonView PV;
    // Start is called before the first frame update
    void Awake()
    {
        //����ƽ���� ����
        DontDestroyOnLoad(this);

        PhotonNetwork.GameVersion = "1.0.0";//���� ������ ����
        PhotonNetwork.SendRate = 20;
        PhotonNetwork.SerializationRate = 10;

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnDisconnected(DisconnectCause cause)//�����������
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
        PhotonNetwork.IsMessageQueueRunning = true;//ť������� �ްڴ�.
    }
}
