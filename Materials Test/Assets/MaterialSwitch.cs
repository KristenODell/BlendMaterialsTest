using UnityEngine;
using System.Collections;

public class MaterialSwitch : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
    public int startColor = 0;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = material1;
    }

    void OnMouseDown()
    {
        startColor += 1;
        if (startColor == 4)
        {
            startColor = 0;
        }
        //float changeMaterial = Mathf.Lerp(startColor, endColor, clicks);
        //rend.material.Lerp(material1, material2, changeMaterial);
        //if (clicks < endColor)
        //{
        //    clicks += .1f;
        //}
        switch (startColor)
        {
            case 0:
                rend.material = material1;
                break;
            case 1:
                rend.material = material2;
                break;
            case 2:
                rend.material = material3;
                break;
            case 3:
                rend.material = material4;
                break;
        }

    }
}
