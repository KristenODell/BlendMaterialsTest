using UnityEngine;
using System.Collections;

public class BlendingTexutresandMaterials : MonoBehaviour
{
    //    public Renderer rend;
    //    public float clicks = .1f;
    //    public float blend;
    //    public float endTexture = 1;
    //    Color color;

    //    void Start()
    //    {
    //        rend = GetComponent<Renderer>();
    //        color = rend.material.color;
    //    }

    //    void OnMouseDown()
    //    {
    //        rend.material.SetAlpha(rend.material.color.a - .1F);
    //    }
    //}


    public Renderer rend;
    public float fadeLerpConstant = 2f;
    Color colorStart;
    Color colorEnd;
    public Material mat;
    public float clicks = 1;

    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = GetComponent<MeshRenderer>().material;
    }

    //void Update ()
    //{
    //    Color newColor = mat.color;
    //    newColor.a -= Time.deltaTime/5;
    //    mat.color = newColor;
    //}

    void OnMouseDown ()
    {
        Color newColor = mat.color;
        newColor.a -= .1f;
        mat.color = newColor;
    }

}