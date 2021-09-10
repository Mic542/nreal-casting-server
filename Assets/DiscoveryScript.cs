using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

#pragma warning disable CS0618 // Type or member is obsolete
public class DiscoveryScript : NetworkDiscovery
{
#pragma warning restore CS0618 // Type or member is obsolete
    public MLAPI.NetworkManager _MLAPIManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void _MLAPIManager_OnClientConnectedCallback(ulong obj)
    {
        Debug.Log("Client Connected");
    }

    public void StartDiscovery()
    {
        Initialize();
        StartAsClient();
    }

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        base.OnReceivedBroadcast(fromAddress, data);
        Debug.Log("Received broadcast " + fromAddress);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
