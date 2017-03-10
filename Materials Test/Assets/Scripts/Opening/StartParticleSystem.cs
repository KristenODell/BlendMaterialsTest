using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class StartParticleSystem : MonoBehaviour
{
    ParticleSystem explosion;

    IEnumerator ParticleStart ()
    {
        int i = 3;
        while (i > 0)
        {
            explosion.Stop();
            yield return new WaitForSeconds(.875f);
            i --;
        }
        explosion.Play();
        
    }
    IEnumerator ChangeTheScene ()
    {
        int i = 4;
        while (i>0)
        {
            yield return new WaitForSeconds(.875f);
            i--;
        }
        SceneManager.LoadScene("MainMenu");
    }

	void Start ()
    {
        explosion = GetComponent<ParticleSystem>();
        explosion.Stop();
        StartCoroutine(ParticleStart());
        StartCoroutine(ChangeTheScene());
	}
	
}
