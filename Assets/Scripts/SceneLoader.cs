using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	static int currentScene;

	public KeyCode nextSceneKey = KeyCode.Space;

	void Start()
	{
		currentScene = SceneManager.GetActiveScene().buildIndex;
	}

	void Update()
	{
		if (Input.GetKeyDown(nextSceneKey))
		{
			var nextScene = (currentScene + 1) % SceneManager.sceneCountInBuildSettings;
			SceneManager.LoadScene(nextScene);
		}
	}
}
