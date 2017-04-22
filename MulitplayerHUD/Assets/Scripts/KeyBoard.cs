using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class KeyBoard : MonoBehaviour
{
    public Text enterPlayerName;
    public string addingLetters;
    public MaximumLetters maxLetters;
    public Canvas keyBoard;
    public static Action<Text> SendThis;

    void Start()
    {
 
    }

    public static Action _PlayerName;

    public void Alphabet()
    {
        if (maxLetters.maximumLetters < 6)
        {
            enterPlayerName.text += addingLetters;
            maxLetters.maximumLetters++;
        }
    }

    public void Backspace()
    {
        enterPlayerName.text= "";
        maxLetters.maximumLetters = 0;
    }

    public void EnterKey()
    {
        keyBoard.enabled = false;
        SendThis(enterPlayerName);
    }
}
