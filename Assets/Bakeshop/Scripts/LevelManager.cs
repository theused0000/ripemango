/// <summary>
/// LevelManager.cs
/// Handles game mode  (easy, medium, hard) and the levels
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {
	public static int currentLevel = 0;
	public static int rdmLevel = 0, rdmMode, newMode;
	public static int scoreMultiplier;
	public static string gameMode = "easy";
	public static string playMode = "story";

	public Text levelTxt;
	void Start()
	{
		// Set database of game mode
		gameMode = PlayerPrefs.GetString ("GameMode");
		currentLevel = PlayerPrefs.GetInt("CurrentLevel"+GameManager.num);
		Debug.Log ("Current Level: "+ PlayerPrefs.GetInt("CurrentLevel"+GameManager.num));
		SelectPlayer.score = PlayerPrefs.GetInt("score"+GameManager.num);
		SelectPlayer.money = PlayerPrefs.GetInt("money"+GameManager.num);
		
		/*// Insert the toggle from the scene to a variable
		Toggle toggleEasy = GameObject.Find ("easy").GetComponent<Toggle>();
		Toggle toggleMedium = GameObject.Find ("medium").GetComponent<Toggle>();
		Toggle toggleHard = GameObject.Find ("hard").GetComponent<Toggle>();

		// Turns on the database game mode or the newly assigned game mode
		if (gameMode == "easy") {
			toggleEasy.isOn = true;
		} else if (gameMode == "medium") {
			toggleMedium.isOn = true;
		} else if (gameMode == "hard") {
			toggleHard.isOn = true;
		} else {
			toggleEasy.isOn = true;
		}*/

	}

	public void hack()
	{
		int lvl = 0;
		if (levelTxt.text != "") {
			lvl = int.Parse (levelTxt.text);
		}

		currentLevel = lvl;
		PlayerPrefs.SetInt("CurrentLevel"+GameManager.num, currentLevel);
		Application.LoadLevel (Application.loadedLevel);
	}

	public void hackMoney() {
		SelectPlayer.money = 1000000;
		PlayerPrefs.SetInt("money"+GameManager.num, SelectPlayer.money);
		Application.LoadLevel (Application.loadedLevel);
	}

	// Sets the level if the level is clicked
	public void setLevel()
	{
		currentLevel = PlayerPrefs.GetInt("CurrentLevel"+GameManager.num);
		currentLevel++;
		Debug.Log ("Current Level: "+ PlayerPrefs.GetInt("CurrentLevel"+GameManager.num));
		playMode = "story";
	}
	// Sets the game mode depends on the toggle click (easy, medium, hard)
	/*public void setMode(string gMode)
	{
		gameMode = gMode;Rw
		PlayerPrefs.SetString ("GameMode", gMode);
	}*/
	public void randomLevel()
	{
		int addRdm = PlayerPrefs.GetInt ("CurrentLevel"+GameManager.num) + 1;
		rdmLevel = Random.Range (1, addRdm-1);
		playMode = "random";
		Debug.Log ("Random Level: "+rdmLevel);
	}
	public void setClue(int x)
	{
		rdmMode = x;
		if (x == 1) {
			scoreMultiplier = 0; // Picture
		} else if (x == 2) {
			scoreMultiplier = 10; // Silhouette
		} else if (x == 3) {
			scoreMultiplier = 5; // Word
		}
	}
	public void setClueDiff(int x)
	{
		newMode = x;
	}
	public static void runTuts()
	{
		PlayerPrefs.SetInt ("CurrentLevel"+GameManager.num, 0);
		currentLevel = 1;
		playMode = "story";
	}
	/*public void difficulty()
	{
		if(currentLevel > 20 && currentLevel < 41 )
		{
			gameMode = "medium";
			PlayerPrefs.SetString("GameMode", "medium");
		}
		else if(currentLevel < 40)
		{
			gameMode = "hard";
			PlayerPrefs.SetString("GameMode", "hard");
		}
	}*/
}
