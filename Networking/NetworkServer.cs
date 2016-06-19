using System;
using UnityEngine.Networking;

public class NetworkServer : NetworkServerSimple
{
    public static NetworkServer instance;

	public NetworkServer ()
	{
        NetworkServer.instance = this;

	}

	public override void OnConnected (NetworkConnection conn)
	{

		base.OnConnected (conn);
	}
}

