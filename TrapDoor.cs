using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{

    public GameObject player = null;
    public GameObject floor = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            StartCoroutine(TrapDoorEnable(3));
        }
    }

    private IEnumerator TrapDoorEnable(float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(floor);
    }
}
