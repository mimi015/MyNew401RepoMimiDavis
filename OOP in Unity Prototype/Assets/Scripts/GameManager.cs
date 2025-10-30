using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{   

	public int score; 
	public GameObject pauseMenu;

	private string CurrentLevelName = string.Empty;

	public void LoadLevel(string levelName)
	{
		AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
		if (ao == null)
		{
			Debug.LogError("[GameManager] Unable to load level " + levelName);
			return;
		}
		CurrentLevelName = levelName;
	}

	public void UnloadLevel(string levelName)
	{
		AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
		if (ao == null)
		{
			Debug.LogError("[GameManager] Unable to unload level " + levelName);
			return;
		}
	}

	//pausing and unpausing 
	public void Pause()
	{
		Time.timeScale = 0f;
		pauseMenu.SetActive(true);
	}

		public void Unpause()
	{
		Time.timeScale = 1f;
		pauseMenu.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			Pause();
		}
	}
}
