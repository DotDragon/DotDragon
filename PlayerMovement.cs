using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 5f;
 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
  
    }
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force);

        }


        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * force);
        }


        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force);
        }



        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force);


        }

    }

  
}

