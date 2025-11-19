using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* Challenge4
* Code for pausing the game when the player first starts the game
*/
public class PauseManagerX : MonoBehaviour
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
