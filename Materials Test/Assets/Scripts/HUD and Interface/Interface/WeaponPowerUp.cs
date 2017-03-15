using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponPowerUp : MonoBehaviour
{
    Image powerUpDial;
    float starting = 0;
    float adding = 0.005f;
    public GameObject halo;

	void Start ()
    {
        powerUpDial = GetComponent<Image>();
        powerUpDial.fillAmount = starting;
        halo.SetActive(false);
	}
	


    void Update ()
    {
        starting += adding;
        powerUpDial.fillAmount = starting;
        if (starting >= 1 && starting <= 1.5)
        {
            halo.SetActive(true);
        }
        else
        {
            halo.SetActive(false);
        }

    }
}
