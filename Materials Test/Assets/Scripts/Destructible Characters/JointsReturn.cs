using UnityEngine;
using System.Collections;
using System;

public class JointsReturn : MonoBehaviour
{
    public GameObject ragDollDinosaurParts;
    float speed = .1f;
    Rigidbody rig;

    IEnumerator RagdollAndBackAgain()
    {
        gameObject.SetActive(false);
        ragDollDinosaurParts.SetActive(true);
        yield return new WaitForSeconds(.5f);
        ragDollDinosaurParts.transform.rotation = Quaternion.Lerp(ragDollDinosaurParts.transform.rotation, gameObject.transform.rotation, Time.time * speed);
        ragDollDinosaurParts.transform.position = Vector3.Lerp(ragDollDinosaurParts.transform.position, gameObject.transform.position, Time.time * speed);
        ragDollDinosaurParts.SetActive(false);
        gameObject.SetActive(true);
    }

    void Start ()
    {
        rig = GetComponent<Rigidbody>();
        ragDollDinosaurParts.SetActive(false);
    }
	

	void OnCollisionEnter()
    {
        StartCoroutine(RagdollAndBackAgain());
    }
}
