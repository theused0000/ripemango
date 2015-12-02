/// <summary>
/// GameStart.cs or The Game Master
/// The official start of the game is in this lines of codes.
/// The head logic for entire levels
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {
	// Gameobjects to be shown and hidden
	public static GameObject breakObj;
	public GameObject levelComplete, levelCompleteBg, game, gameGui, nextBtn;
	public static List<GameObject> objectArray;
	public static List<int> clues;
	public static GameObject[] decorArray, clueObject, wordArray;
	public static int newMode, rdmVowel, objNum, stopper, cluesNum, rdmMode, clueIndex1, clueIndex2, clueIndex3, clueIndex4;
	public GameObject clueMask;
	public string [] vowels = new string[]{"a","e","i","o","u"};
	private bool rotateClues = false;
	public GameObject fader;
	public static int breakCount = 0;
	public static int rewardScore, rewardMoney;
	public GameObject popUp, cashAnim, shopBtn;
	public Text popUpTxt;

	void Start()
	{
		UpdateDbase.numAnim = false;
		breakObj = GameObject.Find ("break");
		breakObj.SetActive (false);
		rdmVowel = Random.Range (0,5);
		clueMask.SetActive (false);
		if (LevelManager.playMode == "story") {
			if(LevelManager.currentLevel < 11)
				rdmMode = 1;
			else 
				rdmMode = Random.Range (1, 4); // 1 Picture= , 2 = Silhouette, 3 = Words

			// 0 = no change, 1 = rotated
			newMode = Random.Range (LevelSpawn.minModeNum, LevelSpawn.maxModeNum);
		} else if(LevelManager.playMode == "random"){
			rdmMode = LevelManager.rdmMode;
			newMode = LevelManager.newMode;
		}

		Debug.Log("Random Game Mode : "+rdmMode);
		setStage();
		randomClues();
		randomDecor();
		if (!Version.noAds) {
			AdsorbAds.LoadHelperAd ("Refill Hint?", "Watch a short message to get extra", "3 Hints", "Tap for more Hints", false);
			AdsorbAds.LoadSuccessAd ("Level Completed", "Earn more points and cash!", false);
		}
	}
	// Runs every game update
	void Update()
	{
		if (rdmMode == 1 || rdmMode == 2) {
			updateClue ();
		}
		else if (rdmMode == 3) {
			updateWords ();
		}

		if(objNum == 15) {
			StartCoroutine("lcDelay");
		}

		// Updates time bonus added score
		UpdateDbase.timeBonus ();
	}

	public void runLastLC() {
		if (LevelManager.currentLevel == 300) {
			runLC();
		}
	}

	public void runLC() {
		levelComplete.SetActive(true);
		levelCompleteBg.SetActive(true);
		game.SetActive(false);
		gameGui.SetActive(false);

		if (LevelManager.playMode == "story") {
			if (LevelManager.currentLevel == 60) {
				cashAnim.GetComponent<Text> ().text = "Cash Bonus: $12000";
				UpdateDbase.addedCash = SelectPlayer.money + 12000;
				shopBtn.SetActive (false);
				nextBtn.SetActive (false);
				StartCoroutine ("cashAnimDelay");
				StartCoroutine ("showShopBtn");
			} else if (LevelManager.currentLevel == 120) {
				cashAnim.GetComponent<Text> ().text = "Cash Bonus: $13000";
				UpdateDbase.addedCash = SelectPlayer.money + 13000;
				shopBtn.SetActive (false);
				nextBtn.SetActive (false);
				StartCoroutine ("cashAnimDelay");
				StartCoroutine ("showShopBtn");
			} else if (LevelManager.currentLevel == 180) {
				cashAnim.GetComponent<Text> ().text = "Cash Bonus: $14000";
				UpdateDbase.addedCash = SelectPlayer.money + 14000;
				shopBtn.SetActive (false);
				nextBtn.SetActive (false);
				StartCoroutine ("cashAnimDelay");
				StartCoroutine ("showShopBtn");
			} else if (LevelManager.currentLevel == 240) {
				cashAnim.GetComponent<Text> ().text = "Cash Bonus: $15000";
				UpdateDbase.addedCash = SelectPlayer.money + 15000;
				shopBtn.SetActive (false);
				nextBtn.SetActive (false);
				StartCoroutine ("cashAnimDelay");
				StartCoroutine ("showShopBtn");
			} else {
				cashAnim.SetActive (false);
			}

			PlayerPrefs.SetInt ("CurrentLevel" + GameManager.num, LevelManager.currentLevel);
			Debug.Log ("Current Level: " + PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num));
		} else {
			cashAnim.SetActive (false);
		}
		
		if(LevelManager.currentLevel == 300) {
			nextBtn.SetActive(false);
		}

		UpdateDbase.updateDatabase();
		UpdateDbase.updateScore();
		UpdateDbase.updateMoney();
		//resetVariables();

		if (LevelManager.currentLevel == 1 && LevelManager.playMode == "story") {
			nextBtn.SetActive(false);
		}

		// Adsorb Ads
		if (PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num) % 3 != 0) {
			rewardScore = SelectPlayer.score + 100;
			rewardMoney = SelectPlayer.money + 50;
			if(!Version.noAds)
				AdsorbAds.ShowSuccessAd (null, null);
		}

		ShowAds.InterstitialAd ();
	}

	IEnumerator cashAnimDelay() {
		yield return new WaitForSeconds (5f);
		UpdateDbase.numAnim = true;
	}

	IEnumerator showShopBtn() {
		yield return new WaitForSeconds (9f);
		shopBtn.SetActive (true);
	}

	IEnumerator lcDelay()
	{
		while(stopper<1)
		{
			stopper++;
			yield return new WaitForSeconds (1.5f);
			runLC();
		}
	}

	public void setStage()
	{
		UpdateDbase.updateDatabase();
		UpdateDbase.updateScore ();
		UpdateDbase.updateMoney();
		resetVars();
		levelComplete.SetActive(false);
		levelCompleteBg.SetActive(false);
		game.SetActive(true);

		objectArray = new List<GameObject>();
		objectArray.AddRange(GameObject.FindGameObjectsWithTag("Hidden Objects"));
		decorArray = GameObject.FindGameObjectsWithTag("Decoratives");
		clueObject = GameObject.FindGameObjectsWithTag("Object Clues");
		wordArray = GameObject.FindGameObjectsWithTag("Word Clues");

		for(int x=0; x<objectArray.Count; x++)
		{
			Image objSprite = objectArray[x].GetComponent<Image>();
			objSprite.sprite = (Sprite)Resources.Load("LevelSprites/"+LevelSpawn.newLevel+"/"+objectArray[x].name, typeof(Sprite));
		}

		for(int x=0; x<decorArray.Length; x++)
		{
			Image objSprite = decorArray[x].GetComponent<Image>();
			objSprite.sprite = (Sprite)Resources.Load("LevelSprites/"+LevelSpawn.newLevel+"/"+decorArray[x].name, typeof(Sprite));
		}

		if (rdmMode == 1 || rdmMode == 2) {
			for (int x = 0; x < 4; x++) {
				wordArray [x].SetActive (false);
			}
		} else if (rdmMode == 3) {
			for (int x = 0; x < 4; x++) {
				clueObject [x].SetActive (false);
			}
		}

		if (newMode == 1) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,0,180,0);
				wordArray [x].transform.rotation = new Quaternion(0,0,180,0);
			}
		} else if (newMode == 2) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,180,0,0);
				wordArray [x].transform.rotation = new Quaternion(0,180,0,0);
			}
		} else 
		if (newMode == 3) {
			for(int x = 0; x < 4; x++) {
				fader.SetActive(true);
			}
		} else if (newMode == 4) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,0,180,0);
				wordArray [x].transform.rotation = new Quaternion(0,0,180,0);
				fader.SetActive(true);
			}
		} else if (newMode == 5) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,180,0,0);
				wordArray [x].transform.rotation = new Quaternion(0,180,0,0);
				fader.SetActive(true);
			}
		} else if (newMode == 6) {
			for(int x = 0; x < 4; x++) {
				clueMask.SetActive(true);
			}
		} else if (newMode == 7) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,0,180,0);
				wordArray [x].transform.rotation = new Quaternion(0,0,180,0);
				clueMask.SetActive(true);
			}
		} else if (newMode == 8) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,180,0,0);
				wordArray [x].transform.rotation = new Quaternion(0,180,0,0);
				clueMask.SetActive(true);
			}
		} else if (newMode == 9) {
			for(int x = 0; x < 4; x++) {
				clueMask.SetActive(true);
				fader.SetActive(true);
			}
		} else if (newMode == 10) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,0,180,0);
				wordArray [x].transform.rotation = new Quaternion(0,0,180,0);
				clueMask.SetActive(true);
				fader.SetActive(true);
			}
		} else if (newMode == 11) {
			for(int x = 0; x < 4; x++) {
				clueObject[x].transform.rotation = new Quaternion(0,180,0,0);
				wordArray [x].transform.rotation = new Quaternion(0,180,0,0);
				clueMask.SetActive(true);
				fader.SetActive(true);
			}
		}
	}

	public void randomDecor()
	{
		int rdmDecor = 0;
		if(LevelManager.gameMode == "easy")
			rdmDecor = 0;
		else if(LevelManager.gameMode == "medium")
			rdmDecor = 1;
		else if(LevelManager.gameMode == "hard")
			rdmDecor = 2;

		int rdmIndex = Random.Range(0,4) * 10;

		objectArray[clues[rdmDecor] + rdmIndex] = decorArray[rdmDecor];
	}

	public void randomClues()
	{
		clues = new List<int>();
		cluesNum = 4;

		// While loop that adds variable of random number to array randomClues
		while(clues.Count < cluesNum)
		{
			int y = Random.Range (0, 10);
			bool sameValue = false;
			
			if (clues.Count == 0)
				clues.Add (y);

			for (int xy =0; xy < clues.Count; xy++)
			{
				if (clues[xy] == y) 
				{
					Debug.Log("xy not equal to y");
					sameValue = true;
					break;
				}

			}
			
			if(!sameValue && clues.Count != 0)
			{
				clues.Add (y);
				Debug.Log ("Added randomClues.");
			}
		}

		for(int x = 0; x<cluesNum; x++)
			Debug.Log ("Clue :" + clues[x]);
	}

	public void changeClue(int objectIndex, int clueIndex, int addedIndex)
	{
		Image clueSprite = clueObject[objectIndex].GetComponent<Image>();
		clueSprite.overrideSprite = (Sprite)Resources.Load("LevelSprites/"+LevelSpawn.newLevel+"/"+objectArray[clues[clueIndex] + addedIndex].name, typeof(Sprite));

		// If mode is 1 w/c is picture mode, change sprite clue color to white so that the black silhouette will have color
		if(rdmMode == 1) {
			clueSprite.color = new Color(255f, 255f, 255f, 255f);
		}
	}

	public void updateClue()
	{
		if (clueIndex1 < 4) {
			changeClue(0, clueIndex1, 0);
		} else {
			clueObject[0].SetActive(false);
		}

		if (clueIndex2 < 4) {
			changeClue(1, clueIndex2, 10);
		} else {
			clueObject[1].SetActive(false);
		}

		if (clueIndex3 < 4) {
			changeClue(2, clueIndex3, 20);
		} else {
			clueObject[2].SetActive(false);
		}

		if (clueIndex4 < 3) {
			changeClue(3, clueIndex4, 30);
		} else {
			clueObject[3].SetActive(false);
		}
	}

	public void changeWord(int objectIndex, int clueIndex, int addedIndex)
	{
		Text clueText = wordArray [objectIndex].GetComponent<Text> ();
		clueText.text = objectArray [clues [clueIndex] + addedIndex].name;
		clueText.text = clueText.text.Replace ("-", " ");
		clueText.text = clueText.text.Replace ("_", " ");
		if (rdmMode == 4)
		{
			//for(int x=0; x<vowels.Length; x++)
			clueText.text = clueText.text.Replace (vowels[rdmVowel], "_");
		}
		clueText.text = clueText.text.ToUpper ();
	}

	public void updateWords()
	{
		if (clueIndex1 < 4) {
			changeWord(0, clueIndex1, 0);
		} else {
			wordArray[0].SetActive(false);
		}

		if (clueIndex2 < 4) {
			changeWord(1, clueIndex2, 10);
		} else {
			wordArray[1].SetActive(false);
		}

		if (clueIndex3 < 4) {
			changeWord(2, clueIndex3, 20);
		} else {
			wordArray[2].SetActive(false);
		}

		if (clueIndex4 < 3) {
			changeWord(3, clueIndex4, 30);
		} else {
			wordArray[3].SetActive(false);
		}
	}

	public void resetVars()
	{
		stopper = 0;
		objNum = 0;
		clueIndex1 = 0;
		clueIndex2 = 0;
		clueIndex3 = 0;
		clueIndex4 = 0;
		GameButtons.hintUsed = false;

		if(objNum < 15)
		{
			SelectPlayer.score = UpdateDbase.newScore;
		}
	}

	public void nextLevel() {
		if (LevelManager.playMode == "story") {
			LevelManager.currentLevel = PlayerPrefs.GetInt("CurrentLevel"+GameManager.num);
			LevelManager.currentLevel++;
			Debug.Log ("Current Level: "+ LevelManager.currentLevel);
			LevelManager.playMode = "story";
		} else
		if (LevelManager.playMode == "random") {
			int addRdm = PlayerPrefs.GetInt ("CurrentLevel"+GameManager.num) + 1;
			LevelManager.rdmLevel = Random.Range (1, addRdm-1);
			LevelManager.playMode = "random";
			LevelManager.rdmMode = rdmMode;
			LevelManager.newMode = newMode;
		}
	}
}
