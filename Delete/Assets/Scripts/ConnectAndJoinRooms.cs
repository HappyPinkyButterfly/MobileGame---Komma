using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class ConnectAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField  createInput;
    public TMP_InputField  joinInput;

    public void CreateRoom()
    {
            PhotonNetwork.CreateRoom(createInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GamePlay");
    }

}
