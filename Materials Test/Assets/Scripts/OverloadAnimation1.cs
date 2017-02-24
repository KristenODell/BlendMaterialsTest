using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OverloadAnimation1 : MonoBehaviour
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
        }
    }
}
