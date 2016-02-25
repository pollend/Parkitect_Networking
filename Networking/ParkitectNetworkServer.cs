using System;
using UnityEngine.Networking;

namespace HelloMod
{
	public class ParkitectNetworkServer : NetworkServerSimple
	{
		public ParkitectNetworkServer ()
		{
		}

		public override void OnConnected (NetworkConnection conn)
		{

			base.OnConnected (conn);
		}
	}
}

