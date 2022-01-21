using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMovement : MonoBehaviour
{
    public GameObject player = null;

    private void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<PlayerMovementXAxis>().enabled = true;
        }
    }
}
