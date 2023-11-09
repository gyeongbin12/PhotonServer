using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class PhotonSetting : MonoBehaviourPunCallbacks
{
    [SerializeField] InputField email;
    [SerializeField] InputField userID;
    [SerializeField] InputField password;

    public void LoginSuccess(LoginResult result)
    {
        PhotonNetwork.AutomaticallySyncScene = false;

        PhotonNetwork.GameVersion = "1.0f";

        PhotonNetwork.NickName = PlayerPrefs.GetString("name");
    }
}
