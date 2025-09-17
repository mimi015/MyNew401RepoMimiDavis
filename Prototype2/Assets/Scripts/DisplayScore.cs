using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    
    public Text textbox;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
        if (score >=5)
        {
            won = true;
            gameOver = true;
        }

        
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                textbox.text = "You lose!\nPress R to Try Again!";
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
