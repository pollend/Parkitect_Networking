using System;
using UnityEngine;
using UnityEngine.Networking;

namespace HelloMod
{
	public class ParkitectNetworking : MonoBehaviour
	{
		ParkitectNetworkServer _server;
		public ParkitectNetworking ()
		{
			_server = new ParkitectNetworkServer ();

			_server.Listen (6000);

		}

		public void OnGuI()
		{
			
		}

	}
}

