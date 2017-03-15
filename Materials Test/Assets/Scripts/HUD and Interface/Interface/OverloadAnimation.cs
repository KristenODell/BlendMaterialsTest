using UnityEngine;
using System.Collections;

public class OverloadAnimation : MonoBehaviour
{
    public Animator anim;
    public int i = 0;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
    void OnMouseDown()
    {
        i++;
        switch (i)
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
            case 5:
                anim.SetBool("Layer5", true);
                break;
        }
    }
}
