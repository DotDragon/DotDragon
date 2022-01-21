using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject cameraOne = null;
    public GameObject cameraTwo = null;
    public GameObject player = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
        }
    }
}
