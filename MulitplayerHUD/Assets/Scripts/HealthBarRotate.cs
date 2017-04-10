using UnityEngine;
using System.Collections;

public class HealthBarRotate: MonoBehaviour
{
    public GameObject player;
    int smooth = 5;
    Quaternion targetRotation;
    

	void Update ()
    {
        if (player != null)
        {
            targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        }
	}
}
