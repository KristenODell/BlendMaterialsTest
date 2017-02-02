using UnityEngine;
using System.Collections;

public class BlendingTextures : MonoBehaviour
{
    public Renderer rend;
    public float clicks = .1f;
    public float blend;
    public float endTexture = 1;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("TEst");
        this.rend.material.SetFloat("_Blend", blend);      
    }

    void OnMouseDown ()
    {
        if (blend < endTexture)
        {
            blend += clicks;
            this.rend.material.SetFloat("_Blend", blend);
        }
        this.rend.material.SetColor("_Color", Color.white);
    }
}
