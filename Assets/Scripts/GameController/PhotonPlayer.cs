﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Photon.Realtime;

public class PhotonPlayer : MonoBehaviourPun
{
    public PhotonView PV;
    public GameObject myAvatar;

    void Start()
    {
        PV = GetComponent<PhotonView>();
        //int spawnPicker = Random.Range(0, GameSetup.GS.spawnPoints.Length);
        
        /*if (PhotonNetwork.IsMasterClient)
        {
            myAvatar = PhotonNetwork.Instantiate(Path.Combine("PrefabController", "PlayerAvatar"),
            GameSetup.GS.spawnPoints[spawnPicker].position, GameSetup.GS.spawnPoints[spawnPicker].rotation);
            Debug.Log("master");
        } else
        {
            myAvatar = PhotonNetwork.Instantiate(Path.Combine("PrefabController", "PlayerAvatar"),
            GameSetup.GS.spawnPoints[spawnPicker].position, GameSetup.GS.spawnPoints[spawnPicker].rotation);
            Debug.Log("client");
        }*/

        /*if (PV.IsMine)
        {
            myAvatar = PhotonNetwork.Instantiate(Path.Combine("PrefabController", "PlayerAvatar"),
                GameSetup.GS.spawnPoints[spawnPicker].position, GameSetup.GS.spawnPoints[spawnPicker].rotation);
        }*/
    }

    void Update()
    {
        
    }
}