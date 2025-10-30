using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   

	public int score; 

	private string CurrentLevelName = string.Empty;

	#region This code makes this class Singleton
	public static GameManager instance;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this; 
			DontDestroyOnLoad(gameObject);
		}
		else 
		{
			Destroy(gameObject);
			Debug.LogError("Trying to instantiate a second" + 
				"instance of singleton Game Manager");
		}
	}
	#endregion

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
}
