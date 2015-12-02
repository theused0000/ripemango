/// <summary>
/// GameButtons.cs
/// Mostly codes for hint function
/// </summary>
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameButtons : MonoBehaviour {
	public static bool hintUsed;
	public static bool hintUsed2;

	private float hintTimer;

	// Hint Start
	public GameObject hintLoadAnim, hintLoad, hintObject, hintParticles, hintParts;
	public static Text hintLeft;
	private AudioSource hintSound;
	public static int hintCount;
	public static GameObject loadAds;
	void Start()
	{
		loadAds = GameObject.Find ("loadAds");
		hintLeft = GameObject.Find ("hintLeft").GetComponent<Text> ();
		loadAds.SetActive (false);
		hintCount = 3;
		hintLeft.text = hintCount+"";
		hintSound = GameObject.Find ("hintSound").GetComponent<AudioSource> ();
		hintUsed = false;
		hintUsed2 = false;

		// Change of hint cooldown based on game mode
		if(LevelManager.gameMode == "easy")
			hintTimer = 20f;
		else if(LevelManager.gameMode == "medium")
			hintTimer = 30f;
		else if(LevelManager.gameMode == "hard")
			hintTimer = 40f;

		// Put gameobjects inside their container variables
		hintLoadAnim = GameObject.Find("hint load anim");
		hintLoad = GameObject.Find ("hint load");
		hintObject = GameObject.Find ("hint");

		// show hint fill-up animation
		hintLoadAnim.SetActive (false);

		if (Version.noAds)
			hintLeft.text = "";

	}

	void Update()
	{
		// Disable or Enable hint button
		/*if (hintUsed || hintUsed2)
			hintObject.GetComponent<Button> ().interactable = false;
		else if (!hintUsed)
			hintObject.GetComponent<Button> ().interactable = true;*/
	}
	
	public void hintPressed()
	{
		if (Version.noAds) {
			if (PinchZoom.stopScale) {
				StartCoroutine ("hintDelay");
				PinchZoom.stopScaleHint = true;
				PinchZoom.stopScale = true;
			} else
				showHint ();
			
			hintUsed = true;
			//hintUsed2 = true;
			hintLoadAnim.SetActive (true);
			hintLoad.SetActive (false);
			hintObject.GetComponent<Button> ().interactable = false;
			
			//GameMaster.updateScore();
			StartCoroutine ("loadHint");
		} else {
			if(hintCount != 0) {
				hintCount--;
				hintLeft.text = hintCount + "";
				if (PinchZoom.stopScale) {
					StartCoroutine ("hintDelay");
					PinchZoom.stopScaleHint = true;
					PinchZoom.stopScale = true;
				} else
					showHint ();
				
				hintUsed = true;
			}
			
			if (hintCount == 0) {
				loadAds.SetActive(true);
				StartCoroutine("adsDelay");
			}
		}
	}
	IEnumerator hintDelay()
	{
		yield return new WaitForSeconds (1f);
		PinchZoom.stopScaleHint = false;
		PinchZoom.stopScale = false;
		showHint ();
	}
	IEnumerator loadHint()
	{
		yield return new WaitForSeconds (hintTimer);
		hintLoadAnim.SetActive (false);
		hintLoad.SetActive (true);
		hintObject.GetComponent<Button>().interactable = true;
		hintUsed = false;
		//hintUsed2 = false;
	}
	// Show hint for next corresponding hiddenobjects
	public void showHint()
	{
		if (GameStart.clueIndex1 < 4 && ObjectPressed.coins1 == null) {
			Transform hintTrans1 = GameStart.objectArray[GameStart.clues[GameStart.clueIndex1]].transform;
			//hintParts = (GameObject)Instantiate (hintParticles, hintTrans1.position, hintTrans1.rotation);
			hintParticles.transform.position = hintTrans1.position;
			hintParticles.GetComponent<ParticleSystem> ().Play();
			hintSound.Play ();
		} else if (GameStart.clueIndex2 < 4 && ObjectPressed.coins2 == null) {
			Transform hintTrans2 = GameStart.objectArray[GameStart.clues[GameStart.clueIndex2]+10].transform;
			//hintParts = (GameObject)Instantiate (hintParticles, hintTrans2.position, hintTrans2.rotation);
			hintParticles.transform.position = hintTrans2.position;
			hintParticles.GetComponent<ParticleSystem> ().Play();
			hintSound.Play ();
		} else if (GameStart.clueIndex3 < 4 && ObjectPressed.coins3 == null) {
			Transform hintTrans3 = GameStart.objectArray[GameStart.clues[GameStart.clueIndex3]+20].transform;
			//hintParts = (GameObject)Instantiate (hintParticles, hintTrans3.position, hintTrans3.rotation);
			hintParticles.transform.position = hintTrans3.position;
			hintParticles.GetComponent<ParticleSystem> ().Play();
			hintSound.Play ();
		} else if (GameStart.clueIndex4 < 3 && ObjectPressed.coins4 == null) {
			Transform hintTrans4 = GameStart.objectArray[GameStart.clues[GameStart.clueIndex4]+30].transform;
			//hintParts = (GameObject)Instantiate (hintParticles, hintTrans4.position, hintTrans4.rotation);
			hintParticles.transform.position = hintTrans4.position;
			hintParticles.GetComponent<ParticleSystem> ().Play();
			hintSound.Play ();
		}else
			Debug.Log ("No more hints.");

		//Destroy (hintParts, 2f);
	}

	IEnumerator adsDelay() {
		yield return new WaitForSeconds (1.5f);
		showHelperAds ();
	}

	public void showHelperAds() {
		//AdsorbAds.ShowHelperAd ("", "");
		Debug.Log("RewardAds");
		//loadAds.GetComponent<Button> ().interactable = false;
		AdsorbAds.ShowHelperAd(null, null);
	}

	// Hint End
}
