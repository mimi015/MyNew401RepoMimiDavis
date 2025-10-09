using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
* Mimi Davis
* UIManager
* Prototype4
* The code establishes the score conditions
*/

public class UIManager : MonoBehaviour
{
    
    public static bool gameOver;
    public static bool won;
    public static int score;

    
    public Text textbox;
    public int scoreToWin;
    public GameObject invisWall;
    
    void Start()
    {
        
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver) 
        {
            textbox.text = "Score: " + score;
        }

        if (score >= scoreToWin)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "Reach the right of the level to win!";
                Destroy(invisWall);
            }
            else
            {
                textbox.text = "You lose! \nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
