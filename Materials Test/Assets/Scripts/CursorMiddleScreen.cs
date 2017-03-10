using UnityEngine;
using System.Collections;

public class CursorMiddleScreen : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
    }
}
