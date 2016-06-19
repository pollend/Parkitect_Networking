using System;
using UnityEngine.Networking;
using UnityEngine;

	public class ParkitectServer : NetworkServerSimple
	{
		public override void Initialize ()
		{
			this.Listen (5000);
			base.Initialize ();
		}
	}


