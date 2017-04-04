using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TitleAppears : MonoBehaviour
{

    public GameObject title;
    public ParticleSystem hologram;
    public Text[] buttons;
    public GameObject titleHalo;

    IEnumerator waitTitle()
    {
        int i = 3;
        while(i>0)
        {
            yield return new WaitForSeconds(1);
            i--;
        }
        title.SetActive(true);
        buttons[0].enabled = true;
        buttons[1].enabled = true;
        buttons[2].enabled = true;
        buttons[3].enabled = true;
        titleHalo.SetActive(true);
    }
	// Use this for initialization
	void Start ()
    {
        hologram.Stop();
        title.SetActive(false);
        titleHalo.SetActive(false);
        buttons[0].enabled = false;
        buttons[1].enabled = false;
        buttons[2].enabled = false;
        buttons[3].enabled = false;
    }


    void OnTriggerEnter()
    {
        hologram.Play();
        StartCoroutine(waitTitle());
    }
}
