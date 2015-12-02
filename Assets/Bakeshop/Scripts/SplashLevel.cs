using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashLevel : MonoBehaviour {
	public Text levelTxt;

	void Start() {
		if(LevelManager.playMode == "story")
			levelTxt.text = "Loading Level: " + LevelManager.currentLevel;
		else
			levelTxt.text = "";
	}
}