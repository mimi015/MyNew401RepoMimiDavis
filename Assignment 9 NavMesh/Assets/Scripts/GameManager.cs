using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* Mimi Davis
* GameManager
* Assignment 6
* Code for loading scenes
*/
public class GameManager : MonoBehaviour
    {
        public void LoadLevel(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
    }

