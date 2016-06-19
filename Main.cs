using UnityEngine;
using HelloMod;


namespace RollercoasterEdit
{
	public class Main : IMod
    {
        public string Identifier { get; set; }

		private GameObject _go;
        public void onEnabled()
        {
            _go = new GameObject ("Network Handle");
            _go.AddComponent<ParkitectNetworking> ();
        }

        public void onDisabled()
        {
		}

        public string Name
        {
            get { return "Track Edit"; }
        }

        public string Description
        {
            get { return "Allows the User to modify track Path"; }
        }


		public string Path { get; set; }

    }
}
