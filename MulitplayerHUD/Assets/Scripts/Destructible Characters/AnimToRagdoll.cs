using UnityEngine;
using System.Collections;

public class AnimToRagdoll : MonoBehaviour
{
    public GameObject ragdollDino;
   // public int health;
   // public Rigidbody dinoRigidbody;
    public GameObject animDinosaur;
	void Start ()
    {
        //dinoRigidbody = GetComponent<Rigidbody>();
        ragdollDino.SetActive(false);
        //health = 5;
	}
	
	void Update ()
    {
        ragdollDino.transform.position = animDinosaur.transform.position;
	    //if (health == 0)
     //   {
     //       ragdollDino.SetActive(true);
     //       //dinoRigidbody.isKinematic = false;
     //       if (animDinosaur != null)
     //       {
     //           animDinosaur.SetActive(false);
     //       }
     //   }
	}
    void OnMouseDown ()
    {
        //if (health == 0)
       // {
            ragdollDino.SetActive(true);
            //dinoRigidbody.isKinematic = false;
            if (animDinosaur != null)
            {
                animDinosaur.SetActive(false);
            }
        //}
    }
}
