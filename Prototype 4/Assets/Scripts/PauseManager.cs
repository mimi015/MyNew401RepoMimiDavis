using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
* Mimi Davis
* Prototype4
* Code for a pause manager at the beginning so the player can read the rules for the game
*/
public class PauseManager : MonoBehaviour
{
    public GameObject startGameTextUI; 
    private bool gameStarted = false;

    void Start()
    {

        Time.timeScale = 0f;

        if (startGameTextUI != null)
        {
            startGameTextUI.SetActive(true);
        }
    }

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            ResumeGame();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gameStarted = true;

        if (startGameTextUI != null)
        {
            startGameTextUI.SetActive(false);
        }
    }
}
