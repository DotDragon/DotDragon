using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform player = null;
    public Vector3 offset = new Vector3(0f, -2f, 5f);
    Vector3 rotation;
    public float speed = 1f;

    private void LateUpdate()
    {
        transform.position = player.transform.position - offset;
        
    }

    
}
