using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePause : MonoBehaviour
{
    public bool gameOn = true;
    
    public GameObject text;

    private void Start()
    {
        
    }


    private void Update()
    {
           if(Input.GetKeyDown(KeyCode.Escape))
            {
                if (gameOn == true)
                {
                    gameOn = false;
                    Time.timeScale = 0f;
                text.SetActive(true);  
                   
                }

                    else if (gameOn == false)
                    {
                        gameOn = true;
                        Time.timeScale = 1f;

                  
                   text.SetActive(false);
                        
                    }
               
                
            }
        
        
    }
}
