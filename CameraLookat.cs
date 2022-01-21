using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookat : MonoBehaviour
{
    public Transform target;
    public float speed = 1;

    private void Update()
    {
        transform.LookAt(target.position);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(target.transform.position, Vector3.up, speed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(target.transform.position, Vector3.up, -speed);
        }
    }
}
