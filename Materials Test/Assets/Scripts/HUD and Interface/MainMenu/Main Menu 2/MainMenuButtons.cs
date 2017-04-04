using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Text[] mainMenuButtons;
    public Text[] startGameMenuButtons;

	void Start ()
    {
        startGameMenuButtons[0].enabled = false;
        startGameMenuButtons[1].enabled = false;
    }
	
    
    public void StartGame ()
    {
        mainMenuButtons[0].enabled = false;
        mainMenuButtons[1].enabled = false;
        mainMenuButtons[2].enabled = false;
        mainMenuButtons[3].enabled = false;
        startGameMenuButtons[0].enabled = true;
        startGameMenuButtons[1].enabled = true;
    }

    public void ExitGame ()
    {
        Application.Quit();
    }

    public void Options ()
    {

    }

    public void PlayerProfile ()
    {

    }
}
