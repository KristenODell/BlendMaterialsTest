using UnityEngine;
using System.Collections;
using System;

public class Dino2Animation : MonoBehaviour
{
    Animator dino2;

    IEnumerator StartRunning ()
    {
        int i = 1;
        while (i > 0)
        {
            dino2.SetBool("run", false);
            yield return new WaitForSeconds(1);
            i--;
        }
        dino2.SetBool("run", true);
    }

	void Start ()
    {
        dino2 = GetComponent<Animator>();
        StartCoroutine(StartRunning());
	}
    
	

	
}
