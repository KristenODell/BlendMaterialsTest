using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public GameObject mainCam;

    float xRotation;
    float yRotation;
    public float speed = 3;

    Vector3 localVelocity;

    Rigidbody rigb;

    void Start()
    {
        rigb = GetComponent<Rigidbody>();
        localVelocity = transform.InverseTransformDirection(rigb.velocity);

    }


    void Update()
    {
        xRotation += Input.GetAxis("Mouse X") * speed;
        yRotation -= Input.GetAxis ("Mouse Y") * speed;

        transform.eulerAngles = new Vector3(0, xRotation, 0);
        mainCam.transform.eulerAngles = new Vector3(yRotation, xRotation, 0);

        rigb.velocity = transform.TransformDirection(localVelocity);

        if (Input.GetAxis("Horizontal") > 0)
        {
            localVelocity.x = speed;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            localVelocity.x = -speed;
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            localVelocity.x = 0;
        }

            if (Input.GetAxis("Vertical") > 0)
            {
                localVelocity.z = speed;
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                localVelocity.z = -speed;
            }
            if (Input.GetAxis("Vertical") == 0)
            {
                localVelocity.z = 0;
            }

        }
}