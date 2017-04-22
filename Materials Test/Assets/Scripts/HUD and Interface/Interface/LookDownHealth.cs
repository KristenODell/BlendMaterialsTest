using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class LookDownHealth : MonoBehaviour
{
    public float gazeTime = 2f;

    private float timer;

    private bool gazedAt = false;
    public GameObject healthbar;


    void Start()
    {
        healthbar.SetActive(false);
    }

    void Update()
    {
        if (gazedAt == true)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                healthbar.SetActive(true);
            }
        }
    }

    public void PointerEnter()
    {
        print("pointer enter");
        gazedAt = true;
    }

    public void PointerExit()
    {
        print("pointer exit");
        gazedAt = false;
        healthbar.SetActive(false);
    }
}