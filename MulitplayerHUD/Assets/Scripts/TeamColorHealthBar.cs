using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TeamColorHealthBar : MonoBehaviour
{

    public bool teamOne;
    Image healthBar;
    public Sprite teamOneHealthBar;
    public static Action DifferentHealthBar;

	// Use this for initialization
	void Start ()
    {
	    if(teamOne == true)
        {
            healthBar.sprite = teamOneHealthBar;
        }
	}
	
}
