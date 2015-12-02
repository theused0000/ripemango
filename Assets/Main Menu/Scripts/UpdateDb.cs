/// <summary>
/// UpdateDb.cs
/// Undefined if it is being used in game codes or not.
/// To be checked
/// </summary>
using UnityEngine;
using System.Collections;

public class UpdateDb : MonoBehaviour {

	void Start() {
		if(!Version.noAds)
			AdsorbAds.ShowInterstitialAd ();
	}
	
	public void updateDatabaseScore()
	{
		int playerPlaying = PlayerPrefs.GetInt("playerPlaying");
		
		if(playerPlaying == 1)
		{
			SelectPlayer.score = PlayerPrefs.GetInt("score1");
		}
		else if(playerPlaying == 2)
		{
			SelectPlayer.score = PlayerPrefs.GetInt("score2");
		}
		else if(playerPlaying == 3)
		{
			SelectPlayer.score = PlayerPrefs.GetInt("score3");
		}
		else if(playerPlaying == 4)
		{
			SelectPlayer.score = PlayerPrefs.GetInt("score4");
		}
		else if(playerPlaying == 5)
		{
			SelectPlayer.score = PlayerPrefs.GetInt("score5");
		}
		
		Debug.Log(SelectPlayer.score);
	}
}
