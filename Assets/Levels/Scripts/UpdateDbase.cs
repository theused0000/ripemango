/// <summary>
/// UpdateDbase.cs
/// Handles the time bonus score reward, updating of score inside game scene and after the level,
/// updating the object number needed to get to finish the level and updating the score playerprefs which is the
/// database of score.
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateDbase : MonoBehaviour {
	public static int newScore, addedCash;
	public static float timeLeft = 5.0f;
	public static int scoreAdded, cashBonus;
	public static bool numAnim;

	//Score added because of time bonus and no hint used
	public static void timeBonus()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft > 3)
			cashBonus = 5;
		else if (timeLeft >= 2.5f)
			cashBonus = 4;
		else if (timeLeft >= 2f)
			cashBonus = 3;
		else if (timeLeft >= 1.5f)
			cashBonus = 2;
		else if (timeLeft >= 1)
			cashBonus = 1;
		else if (timeLeft >= -1)
			cashBonus = 0;

		if (LevelManager.playMode == "story") {
			scoreAdded = cashBonus + LevelSpawn.modeScore;
		} else {
			scoreAdded = cashBonus + LevelSpawn.modeScore + LevelManager.scoreMultiplier;
		}

		//Debug.Log ("Score Added: "+LevelSpawn.modeScore);
	}

	void Update() {
		if (numAnim && addedCash >= SelectPlayer.money) {
			SelectPlayer.money += 51;
			updateMoney();
			PlayerPrefs.SetInt("money"+GameManager.num, SelectPlayer.money);
		}
	}

	public static void updateScore()
	{
		Text scoreTxt = GameObject.Find("score").GetComponent<Text>();
		scoreTxt.text = ""+string.Format("{0:#,###0}", SelectPlayer.score);
	}

	public static void updateMoney()
	{
		// Money
		Text moneyTxt = GameObject.Find("money").GetComponent<Text>();
		moneyTxt.text = "$"+string.Format("{0:#,###0}", SelectPlayer.money);
	}

	public static void updateObjectsNum()
	{
		Text objTxt = GameObject.Find("objectNum").GetComponent<Text>();
		objTxt.text = GameStart.objNum+"/15";
	}

	public static void updateDatabase()
	{
		int playerPlaying = PlayerPrefs.GetInt("playerPlaying");
		
		if(playerPlaying == 1)
		{
			//PlayerPrefs.SetInt("CurrentLevel1", LevelManager.currentLevel);
			PlayerPrefs.SetInt("score1", SelectPlayer.score);
			PlayerPrefs.SetInt("money1", SelectPlayer.money);
			newScore = PlayerPrefs.GetInt("score1");
		}
		else if(playerPlaying == 2)
		{
			//PlayerPrefs.SetInt("CurrentLevel2", LevelManager.currentLevel);
			PlayerPrefs.SetInt("score2", SelectPlayer.score);
			PlayerPrefs.SetInt("money2", SelectPlayer.money);
			newScore = PlayerPrefs.GetInt("score2");
		}
		else if(playerPlaying == 3)
		{
			//PlayerPrefs.SetInt("CurrentLevel3", LevelManager.currentLevel);
			PlayerPrefs.SetInt("score3", SelectPlayer.score);
			PlayerPrefs.SetInt("money3", SelectPlayer.money);
			newScore = PlayerPrefs.GetInt("score3");
		}
		else if(playerPlaying == 4)
		{
			//PlayerPrefs.SetInt("CurrentLevel4", LevelManager.currentLevel);
			PlayerPrefs.SetInt("score4", SelectPlayer.score);
			PlayerPrefs.SetInt("money4", SelectPlayer.money);
			newScore = PlayerPrefs.GetInt("score4");
		}
		else if(playerPlaying == 5)
		{
			//PlayerPrefs.SetInt("CurrentLevel5", LevelManager.currentLevel);
			PlayerPrefs.SetInt("score5", SelectPlayer.score);
			PlayerPrefs.SetInt("money5", SelectPlayer.money);
			newScore = PlayerPrefs.GetInt("score5");
		}
	}
}
