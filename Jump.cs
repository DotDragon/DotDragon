using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public int jumpCount;
    public float force = 200;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {       
            if (jumpCount < 1)
            {
                rb.AddForce(Vector3.up * force);
                jumpCount++;
            }
         
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (jumpCount == 1)
        {
            jumpCount--;
        }       
        
    }
    
}
