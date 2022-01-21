using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "coin")
        {
            Destroy(other.gameObject);
            coins++;
        }
    }

  
}
