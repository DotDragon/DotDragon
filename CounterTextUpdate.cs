using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterTextUpdate : MonoBehaviour
{
    public GameObject player;
    public CoinCounter counter;
    public Text scoreText;

    

    private void Update()
    {
        scoreText.text = "Score " + counter.coins.ToString();
    }
}
