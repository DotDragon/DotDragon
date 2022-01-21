using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTwoWin : MonoBehaviour
{

    public CoinCounter coinCount;
    public GameObject text = null;
    public GameObject image = null;
    public GameObject score = null;
    public int scoreAmmount;
    private float time = 1.5f;



    private void Start()
    {
        Screen.fullScreen = false;
        Time.timeScale = 1f;

    }

    public IEnumerator MenuTimeDelay(float t)
    {
        yield return new WaitForSeconds(t);
        Time.timeScale = 0f;
        text.SetActive(true);
        image.SetActive(true);
        score.SetActive(false);
        StartCoroutine(LevelLoadWait(t));

    }

    public IEnumerator LevelLoadWait(float t)
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("LevelThree");
    }


    private void Update()
    {
        if (coinCount.coins == scoreAmmount)
        {

            StartCoroutine(MenuTimeDelay(time));



        }
    }

}
