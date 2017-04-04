using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGameMenuButtons : MonoBehaviour
{
    public Text[] startButtons;
    public Text[] multiplayerButtons;
	// Use this for initialization
	void Start ()
    {
        multiplayerButtons[0].enabled = false;
        multiplayerButtons[1].enabled = false;
        multiplayerButtons[2].enabled = false;
        multiplayerButtons[3].enabled = false;
    }
	
    public void SinglePlayer()
    {
        startButtons[0].enabled = false;
        startButtons[1].enabled = false;
    }

    public void MultiPlayer ()
    {
        startButtons[0].enabled = false;
        startButtons[1].enabled = false;
        multiplayerButtons[0].enabled = true;
        multiplayerButtons[1].enabled = true;
        multiplayerButtons[2].enabled = true;
        multiplayerButtons[3].enabled = true;

    }
}
