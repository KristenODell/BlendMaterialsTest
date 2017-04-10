using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class HealthBar_KO : MonoBehaviour
{
    public Image blueHealthBar;
    public Image blueHealthBarBackground;
    public Image orangeHealthBar;
    public Image orangeHealthBarBackground;
    public GameObject thePlayer;

    public Image blueHealthBar2;
    public Image blueHealthBarBackground2;
    public Image orangeHealthBar2;
    public Image orangeHealthBarBackground2;

    public float amountDamage = 1;

    public IEnumerator BlueHealthBarDecreasing()
    {
        float i = 1;
        while (i > 0)
        {
            blueHealthBar.fillAmount -= .01f;
            blueHealthBar2.fillAmount -= .01f;
            yield return new WaitForSeconds(.1f);
            i -= .22f;
        }
    }
    public IEnumerator OrangeHealthBarDecreasing()
    {
        float i = 1;
        while (i > 0)
        {
            orangeHealthBar.fillAmount -= .01f;
            orangeHealthBar2.fillAmount -= .01f;
            yield return new WaitForSeconds(.1f);
            i -= .2f;
        }
    }

  

    void Start ()
    {
        orangeHealthBar.enabled = false;
        orangeHealthBarBackground.enabled = false;
        orangeHealthBar2.enabled = false;
        orangeHealthBarBackground2.enabled = false;
    }
	

    void OnMouseDown()
    {
        amountDamage -= .05f;
        if (amountDamage > .25f)
        {
            StartCoroutine(BlueHealthBarDecreasing());
            orangeHealthBar.enabled = false;
            orangeHealthBarBackground.enabled = false;
            orangeHealthBar2.enabled = false;
            orangeHealthBarBackground2.enabled = false;
            blueHealthBar.enabled = true;
            blueHealthBarBackground.enabled = true;
            blueHealthBar2.enabled = true;
            blueHealthBarBackground2.enabled = true;
        }
        if (amountDamage <= .25f)
        {
            orangeHealthBarBackground.enabled = true;
            orangeHealthBar.enabled = true;
            blueHealthBar.enabled = false;
            blueHealthBarBackground.enabled = false;
            orangeHealthBarBackground2.enabled = true;
            orangeHealthBar2.enabled = true;
            blueHealthBar2.enabled = false;
            blueHealthBarBackground2.enabled = false;
            StartCoroutine(OrangeHealthBarDecreasing());
        }
    }
}
