using System;
using UnityEngine;


public class SerializableNetworkBehavior : MonoBehaviour
{
    //only assigned by server
    public static int NetworkIdCount = 0;

    private int networkId = 0;
    private SerializedMonoBehaviour serializedBehavior;

    public int NetworkId{ get{ return this.networkId; } }

    protected virtual void Start()
    {
        serializedBehavior = this.gameObject.GetComponent<SerializedMonoBehaviour> ();
    }

    public int AssignNewId()
    {
        NetworkIdCount++;
        this.networkId = NetworkIdCount;
    }

}

