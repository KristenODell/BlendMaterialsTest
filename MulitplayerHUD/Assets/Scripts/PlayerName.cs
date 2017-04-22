using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    Text playerName;

	// Use this for initialization
	void Start ()
    {
        playerName = GetComponent<Text>();
        KeyBoard.SendThis += CreatePlayerNameHandler;
	}
	
    public void CreatePlayerNameHandler(Text enterPlayerName)
    {
        playerName.text = enterPlayerName.text;
    }

}
