using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
* Mimi Davis
* Prototype4
* Code for the game to detect if the player falls off the platform, displaying the "You Lose" text
*/
public class FallDetector : MonoBehaviour
{
     public float fallThresholdY = -10f; 
    public Text fallWarningText; 

    void Update()
    {
            
       if (transform.position.y < fallThresholdY)
            {
                
                if (fallWarningText != null)
                {
                    fallWarningText.gameObject.SetActive(true);
                }
            }
            else
            {
                
                if (fallWarningText != null && fallWarningText.gameObject.activeSelf)
                {
                    fallWarningText.gameObject.SetActive(false);
                }
            }     

            if (fallWarningText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
       }
}
