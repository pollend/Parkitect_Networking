using System;
using UnityEngine;
using UnityEngine.Networking;

public class ParkitectNetworking : MonoBehaviour
{
    NetworkServer _server;
    public static ParkitectNetworking instance;

    void Start()
    {
        ParkitectNetworking.instance = this;


        _server = new NetworkServer ();

        //_server.RegisterHandler (Protocals.ParkitectBuild, new NetworkMessageDelegate ());
            
        _server.Listen (6000);


    }

    void Start()
    {
    }

}

