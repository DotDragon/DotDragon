using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementXAxis : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 5f;
    public Vector3 turn;
    public Vector3 slowSpeed = new Vector3(.5f, 0f, 0f);



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        turn = new Vector3(0f, 100, 0f);

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.left * force);

        }


        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.right * force);
        }


        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.back * force);
        }



        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.forward * force);


        }

    }
}
