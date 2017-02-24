﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NotificationsBoard : MonoBehaviour
{
    public Animator notifications;
    
    void Start ()
    {
        notifications = GetComponent<Animator>();
    }

    void Update ()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            notifications.SetBool("Start", true);
            notifications.SetBool("Down", false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            notifications.SetBool("Down", true);
            notifications.SetBool("Start", false);
        }
    }

}

