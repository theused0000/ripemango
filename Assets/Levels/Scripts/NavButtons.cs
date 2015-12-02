/// <summary>
/// NavButtons.cs or Navigation Buttons
/// public void function for controlling canvas gameobjects and scenes in game
/// The map controll function
/// 
/// Comment Important:
/// Use crossfade
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NavButtons : MonoBehaviour {
	private CanvasGroup myCanvasGroup;
	private GameObject canvasGameObj;
	private bool fadeIn = false;
	private bool fadeOut = false;
	private AudioSource clickSound;
	private int playerNum = 0;
	public GameObject confirmObj;
	void Start()
	{
		clickSound = GameObject.Find ("clickSound").GetComponent<AudioSource> ();
	}
	void Update()
	{
		if(fadeIn)
		{
			myCanvasGroup = canvasGameObj.GetComponent<CanvasGroup>();
			myCanvasGroup.alpha = myCanvasGroup.alpha + Time.deltaTime * 4f;
			myCanvasGroup.interactable = false;
			if(myCanvasGroup.alpha >= 1)
			{
				myCanvasGroup.alpha = 1;
				myCanvasGroup.interactable = true;
				fadeIn = false;
			}
		}
		else if(fadeOut)
		{
			myCanvasGroup = canvasGameObj.GetComponent<CanvasGroup>();
			myCanvasGroup.alpha = myCanvasGroup.alpha - Time.deltaTime * 4f;
			myCanvasGroup.interactable = false;
			if(myCanvasGroup.alpha <= 0)
			{
				myCanvasGroup.alpha = 0;
				myCanvasGroup.interactable = true;
				fadeOut = false;
				canvasGameObj.SetActive (false);
			}
		}
	}

	public void toggleCanvas(GameObject canvas)
	{
		StartCoroutine("canvasToggle", canvas);
		canvasGameObj = canvas;
		clickSound.Play ();
	}
	IEnumerator canvasToggle(GameObject canvas)
	{
		yield return new WaitForSeconds(0.1f);
		if (canvas.activeSelf) {
			fadeOut = true;
		} else if (!canvas.activeSelf) {
			canvas.GetComponent<CanvasGroup>().alpha = 0;
			fadeIn = true;
			canvas.SetActive (true);
		}
	}

	public void toggleFade(GameObject canvas)
	{
		StartCoroutine("fadeToggle", canvas);
	}
	IEnumerator fadeToggle(GameObject canvas)
	{
		yield return new WaitForSeconds(0.1f);
		if (canvas.activeSelf) {
			canvas.SetActive (false);
			canvas.GetComponent<CanvasGroup>().alpha = 0;
		} else if (!canvas.activeSelf) {
			canvas.SetActive (true);
			canvas.GetComponent<CanvasGroup>().alpha = 1;
		}
	}

	public void toggleNoFade(GameObject canvas)
	{
		if (canvas.activeSelf) {
			canvas.SetActive (false);
		} else if (!canvas.activeSelf) {
			canvas.SetActive (true);
		}
	}

	public void togglePlayerCanvas(GameObject canvas)
	{
		if(CreatePlayer.nameInputed && CreatePlayer.validName)
		{
			StartCoroutine("fadeToggle", canvas);
			canvasGameObj = canvas;
		}
		else
		{
			Debug.Log("Error No player name inputed.");
		}
		clickSound.Play ();
	}

	//Exit current scene Load next scene
	public void reloadScene () {
		StartCoroutine ("sceneReload");
		PlayBGM.fadeOut = true;
		clickSound.Play ();
	}
	IEnumerator sceneReload()
	{
		yield return new WaitForSeconds (0.5f);
		Application.LoadLevel (Application.loadedLevel);
	}

	public void loadScene(string sceneName)
	{
		StartCoroutine ("loading", sceneName);
		PlayBGM.fadeOut = true;
		clickSound.Play ();
	}
	IEnumerator loading(string scene)
	{
		yield return new WaitForSeconds (0.5f);
		Application.LoadLevel(scene);
	}

	public void loadNextLevel()
	{
		StartCoroutine ("loadingNextLevel");
		PlayBGM.fadeOut = true;
		clickSound.Play ();
	}
	IEnumerator loadingNextLevel()
	{
		yield return new WaitForSeconds (0.5f);
		LevelManager.currentLevel++;
		Application.LoadLevel(Application.loadedLevel);
	}

	//Exit Application
	public void exitApp ()
	{
		clickSound.Play ();
		PlayBGM.fadeOut = true;
		StartCoroutine ("waitBeforeExit");
	}
	IEnumerator waitBeforeExit()
	{
		yield return new WaitForSeconds (0.5f);
		Application.Quit ();
	}

	public void resetDatabase()
	{
		PlayerPrefs.DeleteAll();
		//resetStats ();
		PlayerPrefs.SetString("Current Player", "");
		PlayBGM.fadeOut = true;
		Application.LoadLevel(Application.loadedLevel);
	}

	public void confirmDelete(int playerIndex) {
		playerNum = playerIndex;
		confirmObj.SetActive (true);
	}

	public void resetPlayer()
	{
		if (playerNum == 1)
		{
			//if current player is 1 set current name to ""
			if(PlayerPrefs.GetInt("playerPlaying") == 1) {
				PlayerPrefs.SetString("Current Player", "");
			}
			
			PlayerPrefs.SetString("playerName1", "");
			PlayerPrefs.SetInt("score1", 0);
			PlayerPrefs.SetInt("money1", 0);
			PlayerPrefs.SetInt("Top Score1", 0);
			PlayerPrefs.SetString("Top Name1", "");
			resetStats();
		}
		
		else if (playerNum == 2)
		{
			if(PlayerPrefs.GetInt("playerPlaying") == 2) {
				PlayerPrefs.SetString("Current Player", "");
			}
			PlayerPrefs.SetString("playerName2", "");
			PlayerPrefs.SetInt("score2", 0);
			PlayerPrefs.SetInt("money2", 0);
			PlayerPrefs.SetInt("Top Score2", 0);
			PlayerPrefs.SetString("Top Name2", "");
			resetStats();
		}
		
		else if (playerNum == 3)
		{	
			if(PlayerPrefs.GetInt("playerPlaying") == 3) {
				PlayerPrefs.SetString("Current Player", "");
			}
			PlayerPrefs.SetString("playerName3", "");
			PlayerPrefs.SetInt("score3", 0);
			PlayerPrefs.SetInt("money3", 0);
			PlayerPrefs.SetInt("Top Score3", 0);
			PlayerPrefs.SetString("Top Name3", "");
			resetStats();
		}
		
		else if (playerNum == 4)
		{
			if(PlayerPrefs.GetInt("playerPlaying") == 4) {
				PlayerPrefs.SetString("Current Player", "");
			}
			PlayerPrefs.SetString("playerName4", "");
			PlayerPrefs.SetInt("score4", 0);
			PlayerPrefs.SetInt("money4", 0);
			PlayerPrefs.SetInt("Top Score4", 0);
			PlayerPrefs.SetString("Top Name4", "");
			resetStats();
		}
		
		else if (playerNum == 5)
		{
			if(PlayerPrefs.GetInt("playerPlaying") == 5) {
				PlayerPrefs.SetString("Current Player", "");
			}
			PlayerPrefs.SetString("playerName5", "");
			PlayerPrefs.SetInt("score5", 0);
			PlayerPrefs.SetInt("money5", 0);
			PlayerPrefs.SetInt("Top Score5", 0);
			PlayerPrefs.SetString("Top Name5", "");
			resetStats();
		}
		Debug.Log ("Player Num: "+ playerNum);

	}

	public void resetStats()
	{
		for (int x = 0; x < 60; x++) {
			for(int y = 1; y < 6; y++) {
				PlayerPrefs.SetInt(DecorItems.decors[x]+""+playerNum+y, 0);
			}
		}

		PlayerPrefs.SetInt("CurrentLevel"+playerNum, 0);
		PlayerPrefs.SetInt ("ShopNum"+playerNum, 1);
		SelectPlayer.money = 0;
		SelectPlayer.score = 0;
		LevelManager.currentLevel = 0;
		PlayerPrefs.SetInt ("TutorialDone" + playerNum, 0);
		PlayerPrefs.SetString ("Backdrop"+playerNum, "");
		PlayerPrefs.SetInt("NavNotif"+playerNum, 0);
		PlayerPrefs.SetInt("CoinNotif"+playerNum, 0);

		PlayerPrefs.SetString ("sold2" + playerNum, "");
		PlayerPrefs.SetString ("sold3" + playerNum, "");
		PlayerPrefs.SetString ("sold4" + playerNum, "");
		PlayerPrefs.SetString ("sold5" + playerNum, "");

		PlayerPrefs.SetInt ("TapSpecial"+playerNum, 0);
		PlayerPrefs.SetInt ("TapPlay"+playerNum, 0);
		PlayerPrefs.SetInt ("TapStory"+playerNum, 0);
		PlayerPrefs.SetInt ("TapClose"+playerNum, 0);

		for(int x = 1; x < 5; x++) {
			PlayerPrefs.SetInt("PurchaseGuide"+x+playerNum, 0);
		}

		for (int x = 1; x < 3; x++) {
			PlayerPrefs.SetInt("NewShopGuide"+x+playerNum, 0);
		}

		for (int x = 0; x < 12; x++) {
			for(int y = 1; y < 6; y++) {
				PlayerPrefs.SetInt (DecorItems.furnNames[x]+playerNum+y, 0);
				for(int z = 1; z < 6; z++) {
					PlayerPrefs.SetString ("drawer"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("sideTable"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("floorLamp"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("floor"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("portrait"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("landscape"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("gasRange"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("shelf"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("frontTable"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("kitchenTable"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("wallpaper"+"Owned"+playerNum+y+z, "");
					PlayerPrefs.SetString ("window"+"Owned"+playerNum+y+z, "");
				}
			}
		}
		StartCoroutine ("sceneReload");
		//TutorialManager.nextCount = 0;
	}

	public void hideObj(GameObject obj) {
		obj.SetActive (false);
	}
}