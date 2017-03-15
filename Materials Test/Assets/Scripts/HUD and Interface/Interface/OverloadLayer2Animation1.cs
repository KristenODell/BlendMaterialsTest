using UnityEngine;
using System.Collections;

public class OverloadLayer2Animation1 : MonoBehaviour
{
    public Animator anim;
    public OverloadAnimation1 _overload;
    int damage;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        switch (_overload.i)
        {
            case 1:
                anim.SetBool("Layer1", true);
                break;
            case 2:
                anim.SetBool("Layer2", true);
                break;
            case 3:
                anim.SetBool("Layer3", true);
                break;
            case 4:
                anim.SetBool("Layer4", true);
                break;
        }
    }
}
