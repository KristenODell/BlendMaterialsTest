using UnityEngine;
using System.Collections;
using System;

public class MilitaryOrOrganic : MonoBehaviour
{
    public bool organic = false;
    public bool military = false;
    public GameObject organicHealthBar;
    public GameObject militaryHealthBar;

    // Use this for initialization
    void Start()
    {
        organicHealthBar.SetActive(false);
        militaryHealthBar.SetActive(false);
        if (organic == true)
        {
            organicHealthBar.SetActive(false);
        }
        else if (militaryHealthBar == true)
        {
            militaryHealthBar.SetActive(true);
        }
    }

}
