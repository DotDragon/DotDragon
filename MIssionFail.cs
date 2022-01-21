using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MIssionFail : MonoBehaviour
{
  public GameObject player = null;
    public GameObject missionFailedText = null;
    public GameObject background = null;
    public GameObject scoreText = null;
    private bool isPaused = false;
    public string level = null;
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Time.timeScale = 0;
            missionFailedText.SetActive(true);
            scoreText.SetActive(false);
            background.SetActive(true);
            isPaused = true;

        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isPaused == true)
        {
            
            SceneManager.LoadScene(level);
            Time.timeScale = 1f;
        }
    }
}
