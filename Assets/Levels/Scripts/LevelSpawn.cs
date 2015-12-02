using UnityEngine;
using System.Collections;
public class LevelSpawn : MonoBehaviour
{
	public static int newLevel;
	public static int minModeNum, maxModeNum, modeScore;
	private string[] effects = new string[]{ "Heavy Snowfall", "Rain",
										    "Rain Storm", "Snowfall", "Spurt"};
	void Start ()
	{
		if (LevelManager.playMode == "story") {
			setLevel (LevelManager.currentLevel);
		} else {
			setLevel (LevelManager.rdmLevel);
		}

		Debug.Log ("New Level: "+newLevel);
		GameObject gameScene = (GameObject)Instantiate (Resources.Load("Levels/GameScene"), this.gameObject.transform.position, this.gameObject.transform.rotation);
		GameObject levelObj = GameObject.Find("Game");
		GameObject hiddenObjects = (GameObject)Instantiate (Resources.Load("Levels/"+newLevel), levelObj.transform.position, levelObj.transform.rotation);
		GameObject triviaPopUp = (GameObject)Instantiate (Resources.Load("Levels/triviaPopUp"), levelObj.transform.position, levelObj.transform.rotation);
		hiddenObjects.transform.SetParent(GameObject.Find("Game").transform);
		triviaPopUp.transform.SetParent(GameObject.Find("GUI").transform);
		hiddenObjects.transform.localScale = new Vector3(1,1,1);
		triviaPopUp.transform.localScale = new Vector3(1,1,1);
		AssignSprite.setBgFg ();
	}

	public void setStoryScore(int score) {
		if (LevelManager.playMode == "story")
			modeScore = score;
		else if (LevelManager.playMode == "random") {
			modeScore = LevelManager.newMode + 1;
		}
	}

	public void setLevel(int levelNum)
	{
		if(levelNum < 21) {
			fixLevel("easy", 0);
			minModeNum = 0;
			maxModeNum = 0;
			setStoryScore(3);
		} else if(levelNum > 20 && levelNum < 41 ) {
			fixLevel("medium", 20);
			minModeNum = 0;
			maxModeNum = 1;
			setStoryScore(5);
		} else if(levelNum > 40 && levelNum < 61) {
			fixLevel("hard", 40);
			minModeNum = 1;
			maxModeNum = 2;
			setStoryScore(8);
		} else if(levelNum > 60 && levelNum < 81) {
			fixLevel("easy", 60);
			minModeNum = 1;
			maxModeNum = 3;
			setStoryScore(10);
		} else if(levelNum > 80 && levelNum < 101) {
			fixLevel("medium", 80);
			minModeNum = 2;
			maxModeNum = 4;
			setStoryScore(11);
		} else if(levelNum > 100 && levelNum < 121) {
			fixLevel("hard", 100);
			minModeNum = 2;
			maxModeNum = 5;
			setStoryScore(12);
		} else if(levelNum > 120 && levelNum < 141) {
			fixLevel("easy", 120);
			minModeNum = 3;
			maxModeNum = 6;
			setStoryScore(13);
		} else if(levelNum > 140 && levelNum < 161) {
			fixLevel("medium", 140);
			minModeNum = 3;
			maxModeNum = 7;
			setStoryScore(14);
		} else if(levelNum > 160 && levelNum < 181) {
			fixLevel("hard", 160);
			minModeNum = 4;
			maxModeNum = 8;
			setStoryScore(15);
		} else if(levelNum > 180 && levelNum < 201) {
			fixLevel("easy", 180);
			minModeNum = 4;
			maxModeNum = 9;
			setStoryScore(16);
		} else if(levelNum > 200 && levelNum < 221) {
			fixLevel("medium", 200);
			minModeNum = 5;
			maxModeNum = 10;
			setStoryScore(17);
		} else if(levelNum > 220 && levelNum < 241) {
			fixLevel("hard", 220);
			minModeNum = 5;
			maxModeNum = 11;
			setStoryScore(18);
		} else if(levelNum > 240 && levelNum < 261) {
			fixLevel("easy", 240);
			minModeNum = 6;
			maxModeNum = 11;
			setStoryScore(19);
		} else if(levelNum > 260 && levelNum < 281) {
			fixLevel("medium", 260);
			minModeNum = 6;
			maxModeNum = 11;
			setStoryScore(20);
		} else if(levelNum > 280) {
			fixLevel("hard", 280);
			minModeNum = 7;
			maxModeNum = 11;
			setStoryScore(23);
		}
	}
	public void fixLevel(string mode, int levelMinus)
	{
		LevelManager.gameMode = mode;
		PlayerPrefs.SetString ("GameMode", mode);

		if (LevelManager.playMode == "random") {
			newLevel = LevelManager.rdmLevel - levelMinus;
		} else {
			newLevel = LevelManager.currentLevel - levelMinus;
		}

		if (LevelManager.currentLevel > 60)
			addEffects ();
	}
	public void addEffects() {
		int rdmEffects = Random.Range (0, effects.Length - 1);
		if (newLevel != 2 && newLevel != 2 + 20 && newLevel != 2 + 40 &&
		    newLevel != 3 && newLevel != 3 + 20 && newLevel != 3 + 40 &&
		    newLevel != 5 && newLevel != 5 + 20 && newLevel != 5 + 40 &&
		    newLevel != 13 && newLevel != 13 + 20 && newLevel != 13 + 40 &&
		    newLevel != 15 && newLevel != 15 + 20 && newLevel != 15 + 40 &&
		    newLevel != 17 && newLevel != 17 + 20 && newLevel != 17 + 40) {
			GameObject effectsObj = (GameObject)Instantiate (Resources.Load("Effects/"+effects[rdmEffects]), transform.position, transform.rotation);
		}
		Debug.Log("wat happen");
	}
}