using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
* Mimi Davis
* UIManager
* Prototype4
* The code makes you win the game once entering triggerzone
*/

public class WinTriggerZone : MonoBehaviour
{
    public Text winText; 

    void Start()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(false); 
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (winText != null)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }
}
