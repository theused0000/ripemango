using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayObjects : MonoBehaviour {
	public GameObject arcadeUnlocked, storyButton;
	public Text story;

	void Start() {
		if (LevelManager.currentLevel > 59) {
			arcadeUnlocked.SetActive(false);
		}

		if (LevelManager.currentLevel == 300) {
			storyButton.SetActive(false);
			story.text = "You have finished the story. Thank you for playing!";
		}

		if(LevelManager.currentLevel > 59 && LevelManager.currentLevel < 120) {
			if(PlayerPrefs.GetString("sold2"+GameManager.num) != "sold") {
				storyButton.SetActive(false);
				story.text = "Tap Felicia and buy your new bakeshop to continue story mode.";
			}
		} else if(LevelManager.currentLevel > 119 && LevelManager.currentLevel < 180 ) {
			if(PlayerPrefs.GetString("sold3"+GameManager.num) != "sold") {
				storyButton.SetActive(false);
				story.text = "Tap Felicia and buy your new bakeshop to continue story mode.";
			}
		} else if(LevelManager.currentLevel > 179 && LevelManager.currentLevel < 240) {
			if(PlayerPrefs.GetString("sold4"+GameManager.num) != "sold") {
				storyButton.SetActive(false);
				story.text = "Tap Felicia and buy your new bakeshop to continue story mode.";
			}
		} else if(LevelManager.currentLevel > 239) {
			if(PlayerPrefs.GetString("sold5"+GameManager.num) != "sold") {
				storyButton.SetActive(false);
				story.text = "Tap Felicia and buy your new bakeshop to continue story mode.";
			}
		}
	}
}