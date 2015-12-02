using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUp : MonoBehaviour {
	public GameObject popUp;
	public Text popUpTxt;

	void Start() {
		if (LevelManager.currentLevel == 21) {
			popUp.SetActive (true);
			popUpTxt.text = "A new SEARCH MODE has been unlocked. You may encounter seeing the clues " +
				"rotated up-side down as you progress through the game.";
		} else if (LevelManager.currentLevel == 41) {
			popUp.SetActive (true);
			popUpTxt.text = "A new SEARCH MODE has been unlocked. You may encounter seeing the clues " +
				"flipped or mirrored as you progress through the game.";
		} else if (LevelManager.currentLevel == 61) {
			popUp.SetActive (true);
			popUpTxt.text = "A new SEARCH MODE has been unlocked. You may encounter seeing the clues " +
				"fading every 3 or 2 seconds as you progress through the game.";
		} else if (LevelManager.currentLevel == 81) {
			popUp.SetActive (true);
			popUpTxt.text = "A new SEARCH MODE has been unlocked. You may encounter seeing the clues " +
				"rotated and fading every 3 or 2 seconds as you progress through the game.";
		} else if (LevelManager.currentLevel == 101) {
			popUp.SetActive (true);
			popUpTxt.text = "A new SEARCH MODE has been unlocked. You may encounter seeing the clues " +
				"flipped and fading every 3 or 2 seconds as you progress through the game.";
		}

		if(LevelManager.currentLevel == 7 ) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Flooring from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 13) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Windows from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 17) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Landscape Paintings from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 22) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Portrait Paintings from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 26) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Floor Lamps from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 36) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Drawer from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 43) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Side Tables from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 51) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Front Tables from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 59) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Kitchen Tables from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 68) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Shelf from the shop. Let's check it out!";
		} else if(LevelManager.currentLevel == 72) {
			popUp.SetActive(true);
			popUpTxt.text = "You can now purchase new Gas Range from the shop. Let's check it out!";
		}

		if(LevelManager.currentLevel == 121) {
			popUp.SetActive(true);
			popUpTxt.text = "Hey "+PlayerPrefs.GetString("playerName"+GameManager.num)+", my dad said he found another place in Dublanc for another expansion! Isn’t that great? Let’s check it out later.";
		} else if(LevelManager.currentLevel == 181) {
			popUp.SetActive(true);
			popUpTxt.text = "Hey "+PlayerPrefs.GetString("playerName"+GameManager.num)+", my dad said he found another place in Francia for another expansion! Isn’t that great? Let’s check it out later.";
		} else if(LevelManager.currentLevel == 241) {
			popUp.SetActive(true);
			popUpTxt.text = "Hey "+PlayerPrefs.GetString("playerName"+GameManager.num)+", my dad said he found another place in Laxbourg for another expansion! Isn’t that great? Let’s check it out later.";
		}
	}
}
