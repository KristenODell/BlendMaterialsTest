using UnityEngine;
using System.Collections;

public class BlendingTexutresandMaterials : MonoBehaviour
{
    public Renderer rend;
    public Material mat;
    public float clicks = 1;

    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = GetComponent<MeshRenderer>().material;
    }


    void OnMouseDown ()
    {
        Color newColor = mat.color;
        newColor.a -= .1f;
        mat.color = newColor;
    }

}