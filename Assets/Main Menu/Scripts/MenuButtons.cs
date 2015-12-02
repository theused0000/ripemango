/// <summary>
/// MenuButtons.cs
/// Handles main menu game canvases
/// </summary>
using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {
	//imports for game screens
	public GameObject goMainMenu;
	public GameObject goLevelScreen;
	public GameObject mmBg;
	public GameObject lsBg;

	void Start()
	{
		//Main menu is shown and level screen is hidden
		goLevelScreen.SetActive (false);
		goMainMenu.SetActive (true);
		mmBg.SetActive (true);
		lsBg.SetActive(false);

	}

	//Load scene
	public void LoadGameLevel (string levelName) {
		Application.LoadLevel (levelName);
	}
	


}
