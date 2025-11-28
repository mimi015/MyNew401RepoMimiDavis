using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* Mimi Davis
* ReturnToMenu
* Assignment 6
* Code for loading level select
*/
public class ReturnToMenu : MonoBehaviour
{
   public void GoToMainMenu()
   {
		SceneManager.LoadScene("MainMenu");
   }
}
