using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
* Mimi Davis
* WinText
* Assignment 6
* Code for when the player gets to the end of Level 3, they get a "You Win!" text and allows them to restart that level
*/
public class WinText : MonoBehaviour
{
    public Text textToDisplay; 
    

    void Start()
    {
        
        if (textToDisplay != null)
        {
            textToDisplay.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")) 
        {
            if (textToDisplay != null)
            {
                textToDisplay.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if (textToDisplay != null)
            {
                textToDisplay.gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
