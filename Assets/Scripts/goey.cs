using UnityEngine;
using UnityEngine.SceneManagement;

public class goey : MonoBehaviour
{
	public string model1;
	public string model2;
	public string model3;
	public string model4;

	//add button names here

	public GUISkin skinny;

	public float buttonWidth = 95.0f; //modifies buttonWidth, for longer Strings

	public bool soundEnabled = true;
	public bool guiEnabled = true;

	private int screenwidth = Screen.width;
	private int screenhieght = Screen.height;

	private void Update()
	{
		if (Input.GetKeyDown("escape"))
		{
			Application.Quit();
		}
		if (Input.GetKeyDown("r"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if (Input.GetKeyDown("m") && soundEnabled)
		{
			GetComponent<AudioListener>().enabled = false;
			soundEnabled = false;
		}
		else if (Input.GetKeyDown("m") && !soundEnabled)
		{
			GetComponent<AudioListener>().enabled = true;
			soundEnabled = true;
		}
		if (Input.GetKeyDown("h") && guiEnabled)
		{
			guiEnabled = false;
		}
		else if (Input.GetKeyDown("h") && !guiEnabled)
		{
			guiEnabled = true;
		}
	}

	void OnGUI()
	{
		if (guiEnabled)
		{
			GUI.skin = skinny;

			GUI.Label(new Rect(screenwidth - 175, screenhieght - 50, 200, 30), "3D model visualizer v1");
			GUI.Label(new Rect(screenwidth - 130, screenhieght - 30, 200, 30), "by Fusobotic");

			GUI.Label(new Rect(15, screenhieght - 60, 500, 30), "Hit M to mute audio, H to hide user interface");
			GUI.Label(new Rect(20, screenhieght - 40, 500, 30), "Hit R to reset view and Escape to quit");

			GUI.Label(new Rect(screenwidth - 310, 30, 500, 30), "Left click to rotate, middle click to zoom");
			GUI.Label(new Rect(screenwidth - 250, 60, 500, 30), "Alt-Left click to adjust lights");
			GUI.Label(new Rect(screenwidth - 175, 90, 500, 30), "WASD to pan");

			//add additional buttons/scenes here, remember to go 40 units down, and one up on the LoadLevel and "model#"
			if (GUI.Button(new Rect(20, 20, buttonWidth, 25), model1))
			{
				SceneManager.LoadScene("0");
			}
			if (GUI.Button(new Rect(20, 60, buttonWidth, 25), model2))
			{
				SceneManager.LoadScene("1");
			}
			if (GUI.Button(new Rect(20, 100, buttonWidth, 25), model3))
			{
				SceneManager.LoadScene("2");
			}
			if (GUI.Button(new Rect(20, 140, buttonWidth, 25), model4))
			{
				SceneManager.LoadScene("3");
			}
		}
	}
}