using UnityEngine;
using System.Collections;

public class MaterialBlend : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public float endColor = 1.2F;
    public float clicks = .1f;
    public float startColor = 0;
    public Renderer rend;

    void Start()
        {
            rend = GetComponent<Renderer>();
            rend.material = material1;
        }

    void OnMouseDown()
        {
        float changeMaterial = Mathf.Lerp(startColor, endColor, clicks);
        rend.material.Lerp(material1, material2, changeMaterial);
        if (clicks < endColor)
            {
                clicks += .1f;
            }
        }
}

