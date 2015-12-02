/// <summary>
/// SelectPlayer.cs
/// Handles player selection, deletion, and updating existing score for current player.
/// </summary>
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectPlayer : MonoBehaviour {
	public static string currentPlayer = "";
	public static int score;
	public static int money;
	
	public GameObject wcName;
	
	public GameObject objPlayer1;
	public GameObject objPlayer2;
	public GameObject objPlayer3;
	public GameObject objPlayer4;
	public GameObject objPlayer5;
	public Toggle player1, player2, player3, player4, player5;

	void Start()
	{
		player1 = objPlayer1.GetComponent<Toggle>();
		player2 = objPlayer2.GetComponent<Toggle>();
		player3 = objPlayer3.GetComponent<Toggle>();
		player4 = objPlayer4.GetComponent<Toggle>();
		player5 = objPlayer5.GetComponent<Toggle>();
		setPlayer ();
	}

	void Update()
	{
		currentPlayer = PlayerPrefs.GetString("Current Player");
		wcName.GetComponent<Text>().text = PlayerPrefs.GetString("Current Player");
	}

	public void selectPlayer()
	{
		if(player1.isOn) {
			currentPlayer = PlayerPrefs.GetString("playerName1");
			score = PlayerPrefs.GetInt("score1");
			money = PlayerPrefs.GetInt("money1");
			PlayerPrefs.SetInt("playerPlaying", 1);
		} else if(player2.isOn) {
			currentPlayer = PlayerPrefs.GetString("playerName2");
			score = PlayerPrefs.GetInt("score2");
			money = PlayerPrefs.GetInt("money2");
			PlayerPrefs.SetInt("playerPlaying", 2);
		} else if(player3.isOn) {
			currentPlayer = PlayerPrefs.GetString("playerName3");
			score = PlayerPrefs.GetInt("score3");
			money = PlayerPrefs.GetInt("money3");
			PlayerPrefs.SetInt("playerPlaying", 3);
		} else if(player4.isOn) {
			currentPlayer = PlayerPrefs.GetString("playerName4");
			score = PlayerPrefs.GetInt("score4");
			money = PlayerPrefs.GetInt("money4");
			PlayerPrefs.SetInt("playerPlaying", 4);
		} else if(player5.isOn) {
			currentPlayer = PlayerPrefs.GetString("playerName5");
			score = PlayerPrefs.GetInt("score5");
			money = PlayerPrefs.GetInt("money5");
			PlayerPrefs.SetInt("playerPlaying", 5);
		}

		PlayerPrefs.SetString("Current Player",currentPlayer);
		wcName.GetComponent<Text>().text = currentPlayer;
	}

	public void setPlayer()
	{
		if (PlayerPrefs.GetInt ("playerPlaying") == 0) {
			player1.isOn = true;
		} else {
			if(PlayerPrefs.GetInt ("playerPlaying") == 1) {
				player1.isOn = true;
			} else if (PlayerPrefs.GetInt ("playerPlaying") == 2) {
				player2.isOn = true;
			} else if (PlayerPrefs.GetInt ("playerPlaying") == 3) {
				player3.isOn = true;
			} else if (PlayerPrefs.GetInt ("playerPlaying") == 4) {
				player4.isOn = true;
			} else if (PlayerPrefs.GetInt ("playerPlaying") == 5) {
				player5.isOn = true;
			}
		}
	}
}