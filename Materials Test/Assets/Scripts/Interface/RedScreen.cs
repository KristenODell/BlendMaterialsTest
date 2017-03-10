using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RedScreen : MonoBehaviour
{
    public Animator redScreen;
    public OverloadAnimation1 _overload;


    void Start()
    {
        redScreen = GetComponent<Animator>();
    }

    void Update ()
    {
        if(_overload.i == 3)
        {
            redScreen.SetBool("Starting", true);
        }
        if(_overload.i == 4)
        {
            redScreen.SetBool("Dying", true);
        }
    }
}