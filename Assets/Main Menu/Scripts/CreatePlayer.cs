/// <summary>
/// CreatePlayer.cs
/// Manage creating new players and restriction to create existing player name, or invalid player names
/// </summary>
using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class CreatePlayer : MonoBehaviour 
{
	public static bool nameInputed = false;
	public static bool validName = false;
	public GameObject playerText;
	
	public GameObject objPlayerName1;
	public GameObject objPlayerName2;
	public GameObject objPlayerName3;
	public GameObject objPlayerName4;
	public GameObject objPlayerName5;
	
	public Text warning;
	public GameObject warningBox;
	
	void Start()
	{
		setPlayerName();
	}

	public void newPlayer()
	{
		string pName1 = PlayerPrefs.GetString("playerName1");
		string pName2 = PlayerPrefs.GetString("playerName2");
		string pName3 = PlayerPrefs.GetString("playerName3");
		string pName4 = PlayerPrefs.GetString("playerName4");
		string pName5 = PlayerPrefs.GetString("playerName5");
		string pText = playerText.GetComponent<Text>().text;
		
		if(pName1 == "")
		{
			if(pText == pName2 || pText == pName3 || pText == pName4 || pText == pName5) {
				showWarning("Oops, this profile name is already in use. Please create a new name to start the game.");
				validName = false;
			} else {
				PlayerPrefs.SetString("playerName1", pText);
				validName = true;
			}
		}
		else if(pName2 == "")
		{
			if(pText == pName1 || pText == pName3 || pText == pName4 || pText == pName5) {
				showWarning("Oops, this profile name is already in use. Please create a new name to start the game.");
				validName = false;
			} else {
				PlayerPrefs.SetString("playerName2", pText);
				validName = true;
			}
		}
		else if(pName3 == "")
		{
			if(pText == pName1 || pText == pName2 || pText == pName4 || pText == pName5) {
				showWarning("Oops, this profile name is already in use. Please create a new name to start the game.");
				validName = false;
			} else {
				PlayerPrefs.SetString("playerName3", pText);
				validName = true;
			}
		}
		else if(pName4 == "")
		{
			if(pText == pName1 || pText == pName2 || pText == pName3 || pText == pName5) {
				showWarning("Oops, this profile name is already in use. Please create a new name to start the game.");
				validName = false;
			} else {
				PlayerPrefs.SetString("playerName4", pText);
				validName = true;
			}
		}
		else if(pName5 == "")
		{
			if(pText == pName1 || pText == pName2 || pText == pName3 || pText == pName4) {
				showWarning("Oops, this profile name is already in use. Please create a new name to start the game.");
				validName = false;
			} else {
				PlayerPrefs.SetString("playerName5", pText);
				validName = true;
			}
		}
		
		if(pText == "")
		{
			nameInputed = false;
			showWarning("Please enter your name and press create.");
		}
		else
		{
			nameInputed = true;
			setPlayerName();
		}
	}

	public void showWarning(string sentence) {
		warningBox.SetActive (true);
		warning.text = sentence;
	}
	
	public void setPlayerName()
	{
		objPlayerName1.GetComponent<Text>().text = PlayerPrefs.GetString("playerName1");
		objPlayerName2.GetComponent<Text>().text = PlayerPrefs.GetString("playerName2");
		objPlayerName3.GetComponent<Text>().text = PlayerPrefs.GetString("playerName3");
		objPlayerName4.GetComponent<Text>().text = PlayerPrefs.GetString("playerName4");
		objPlayerName5.GetComponent<Text>().text = PlayerPrefs.GetString("playerName5");
	}
	
}