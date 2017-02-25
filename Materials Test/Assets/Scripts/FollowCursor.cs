using UnityEngine;
using System.Collections;
using System;

public class FollowCursor : MonoBehaviour
{
    int i = 5;
    public GameObject halo;
    float wait = .2f;

	// Use this for initialization
	void Start ()
    {
        //halo = GetComponent<GameObject>();
        halo.SetActive(false);
	}
    
    public IEnumerator ShootHalo()
    {
        while (i > 0)
        {
            halo.SetActive(true);
            yield return new WaitForSeconds(wait);
            i -= 5;
        }
        halo.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
        if(Input.GetMouseButtonDown(0))
        {
            i = 5;
            StartCoroutine(ShootHalo());
        }
	}

}
