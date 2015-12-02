/// <summary>
/// Leaderboard.cs
/// Handles player scores and top player names sorting from highest to lowest
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Leaderboard : MonoBehaviour {
	public GameObject topName1;
	public GameObject topName2;
	public GameObject topName3;
	public GameObject topName4;
	public GameObject topName5;
	
	public GameObject scoreText1;
	public GameObject scoreText2;
	public GameObject scoreText3;
	public GameObject scoreText4;
	public GameObject scoreText5;
	 	 
	// Use this for initialization
	void Start () {
		Debug.Log(PlayerPrefs.GetString("playerName1"));
		
		int p1score = PlayerPrefs.GetInt("score1");
		int p2score = PlayerPrefs.GetInt("score2");
		int p3score = PlayerPrefs.GetInt("score3");
		int p4score = PlayerPrefs.GetInt("score4");
		int p5score = PlayerPrefs.GetInt("score5");
		
		List<int> scores = new List<int>{p1score, p2score, p3score, p4score, p5score};
		scores.Sort();
		
		int y = 5;
		foreach (int x in scores)
		{
			PlayerPrefs.SetInt("Top Score"+y, x);
			
			if(p1score == x && x !=0)
				PlayerPrefs.SetString("Top Name"+y, PlayerPrefs.GetString("playerName1"));
			else if(p2score == x && x !=0)
				PlayerPrefs.SetString("Top Name"+y, PlayerPrefs.GetString("playerName2"));
			else if(p3score == x && x !=0)
				PlayerPrefs.SetString("Top Name"+y, PlayerPrefs.GetString("playerName3"));
			else if(p4score == x && x !=0)
				PlayerPrefs.SetString("Top Name"+y, PlayerPrefs.GetString("playerName4"));
			else if(p5score == x && x !=0)
				PlayerPrefs.SetString("Top Name"+y, PlayerPrefs.GetString("playerName5"));
			else
				PlayerPrefs.SetString("Top Name"+y, "");

			y--;
		}
		
		//PlayerPrefs.SetString("Top Name1", PlayerPrefs.GetString("playerName1"));
		
		setScores();
		setPlayerNames();
	}
	
	public void setScores()
	{
		scoreText1.GetComponent<Text>().text = ""+PlayerPrefs.GetInt("Top Score1");
		scoreText2.GetComponent<Text>().text = ""+PlayerPrefs.GetInt("Top Score2");
		scoreText3.GetComponent<Text>().text = ""+PlayerPrefs.GetInt("Top Score3");
		scoreText4.GetComponent<Text>().text = ""+PlayerPrefs.GetInt("Top Score4");
		scoreText5.GetComponent<Text>().text = ""+PlayerPrefs.GetInt("Top Score5");
	}
	
	public void setPlayerNames()
	{
		topName1.GetComponent<Text>().text = "1. "+PlayerPrefs.GetString("Top Name1");
		topName2.GetComponent<Text>().text = "2. "+PlayerPrefs.GetString("Top Name2");
		topName3.GetComponent<Text>().text = "3. "+PlayerPrefs.GetString("Top Name3");
		topName4.GetComponent<Text>().text = "4. "+PlayerPrefs.GetString("Top Name4");
		topName5.GetComponent<Text>().text = "5. "+PlayerPrefs.GetString("Top Name5");
	}
}
