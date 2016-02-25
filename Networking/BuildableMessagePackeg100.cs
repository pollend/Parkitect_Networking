using System;

namespace HelloMod
{
	public class BuildableMessagePackeg100
	{
		public BuildableMessagePackeg100 (SerializedMonoBehaviour mono)
		{
			SerializationContext context = new SerializationContext (SerializationContext.Context.Savegame);
			Serializer.serialize (context, mono);
			mono.getJSONString (context);
		}
	}
}

