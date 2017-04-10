using UnityEngine;
using System.Collections;
using System;

public class SendToHealthBar : MonoBehaviour
{
    public bool player1;
    public bool player2;
    public bool player3;
    public bool player4;

    public static Action<SendToHealthBar> SendThis;

	void Start ()
    {
	    if(SendThis != null)
        {
            SendThis(this);
        }
	}
}
