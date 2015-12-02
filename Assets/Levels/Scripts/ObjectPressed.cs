/// <summary>
/// ObjectPressed.cs
/// This code handles the response and game variable increments when a hidden object is clicked.
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectPressed : MonoBehaviour {
	private float delayDestroy = 1.3f;
	public static bool objectPressed = false;
	private float updateDelay = 1.2f;
	//private GameObject glowParts;
	private string objectPressedName = "";
	public static string objectPressedName2 = "";
	public static GameObject objClue;
	private IEnumerator enlargeRoutine;
	private Animator comboAnimator;
	//private Animator scoreBonusAnimator;
	private GameObject scoreGameObj;
	public static GameObject coins1, coins2, coins3, coins4;
	public static int newMoneyBns;
	public static string[] coinName;
	public static int[] currentCoin = new int[]{0,0,0,0};
	private AudioSource foundSound;

	void Start()
	{
		foundSound = GameObject.Find ("foundSound").GetComponent<AudioSource> ();
		comboAnimator = GameObject.Find ("bar").GetComponent<Animator>();
		//scoreBonusAnimator = GameObject.Find ("scoreBonus").GetComponent<Animator>();
		scoreGameObj = GameObject.Find ("scoreBonusPoint");
	}
	public void objectHit()
	{

		if (GameStart.clueIndex1 > 3) {
			Debug.Log ("Clue 1 complete.");
		} else if (this.gameObject.name == GameStart.objectArray [GameStart.clues [GameStart.clueIndex1]].name) {
			objectPressedName = this.gameObject.name;
			objectPressedName2 = this.gameObject.name;
			StartCoroutine ("delayUpdate", 1);
			updateVars ();
			//this.gameObject.SetActive(false);
		}

		if (GameStart.clueIndex2 > 3) {
			Debug.Log ("Clue 2 complete.");
		} else if (this.gameObject.name == GameStart.objectArray [GameStart.clues [GameStart.clueIndex2] + 10].name) {
			objectPressedName = this.gameObject.name;
			objectPressedName2 = this.gameObject.name;
			StartCoroutine ("delayUpdate", 2);
			updateVars ();
			//this.gameObject.SetActive(false);
		}

		if (GameStart.clueIndex3 > 3) {
			Debug.Log ("Clue 2 complete.");
		} else if (this.gameObject.name == GameStart.objectArray [GameStart.clues [GameStart.clueIndex3] + 20].name) {
			objectPressedName = this.gameObject.name;
			objectPressedName2 = this.gameObject.name;
			StartCoroutine ("delayUpdate", 3);
			updateVars ();
			//this.gameObject.SetActive(false);
		}

		if (GameStart.clueIndex4 > 2) {
			Debug.Log ("Clue 2 complete.");
		} else if (this.gameObject.name == GameStart.objectArray [GameStart.clues [GameStart.clueIndex4] + 30].name) {
			objectPressedName = this.gameObject.name;
			objectPressedName2 = this.gameObject.name;
			StartCoroutine ("delayUpdate", 4);
			updateVars ();
			//this.gameObject.SetActive(false);
		}
		breakInc ();
		UpdateDbase.updateScore();
		UpdateDbase.updateObjectsNum ();
	}

	private void breakInc() {
		GameStart.breakCount++;
		if(GameStart.breakCount > 4) {
			GameStart.breakObj.SetActive(true);
			StartCoroutine("hideObj", GameStart.breakObj);
			GameStart.breakCount = 0;
		}
	}

	IEnumerator hideObj(GameObject obj) {
		yield return new WaitForSeconds (2f);
		obj.SetActive (false);
	}

	private void updateVars() {
		GameStart.breakCount = 0;
		newMoneyBns = UpdateDbase.scoreAdded;
		foundSound.Play ();
		PinchZoom.stopScale = false;
		SelectPlayer.score += UpdateDbase.scoreAdded;
		objectPressed = true;
		StartCoroutine("disableButton");
		comboAnimator.Play (0);
		int sbonus = UpdateDbase.cashBonus;
		if (UpdateDbase.timeLeft > 1)
		{
			GameObject scoreAnim = (GameObject)Instantiate (Resources.Load("Levels/scoreBonus"), scoreGameObj.transform.position, scoreGameObj.transform.rotation);
			scoreAnim.transform.SetParent(GameObject.Find("time_bonus").transform);
			scoreAnim.transform.localScale = new Vector3(1,1,1);
			//scoreBonusAnimator.Play ("scoreBonus");
			Text scoreBonusTxt = GameObject.Find ("scoreBonus(Clone)").GetComponent<Text>();
			scoreBonusTxt.text = "Cash Bonus: " + sbonus;
			scoreAnim.name = "scoreBonusPrefab";
			Destroy (scoreAnim, 5f);
		}
		UpdateDbase.timeLeft = 5.0f;
		Debug.Log (UpdateDbase.scoreAdded);
	}
	IEnumerator disableButton()
	{
		for(int x = 0; x < GameStart.objectArray.Count; x++) {
			GameStart.objectArray[x].GetComponent<Button>().interactable = false;
		}
		yield return new WaitForSeconds(delayDestroy);
		for(int x = 0; x < GameStart.objectArray.Count; x++) {
			GameStart.objectArray[x].GetComponent<Button>().interactable = true;
		}
	}
	void Update()
	{
		GameObject obj = this.gameObject;

		if(GameStart.clueIndex1 > 3) {
		}
		else if (objectPressedName == GameStart.objectArray[GameStart.clues[GameStart.clueIndex1]].name && objectPressed)
		{
			if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
				objClue = GameStart.clueObject[0];
			else if(GameStart.rdmMode == 3)
				objClue = GameStart.wordArray[0];
			if(obj.transform.position.y < objClue.transform.position.y + 0.3 && obj.transform.position.x < objClue.transform.position.x + 0.3)
				obj.transform.rotation = new Quaternion(0f,0f,0f,0f);
			else
				moveObject(objClue, obj);
		}

		if(GameStart.clueIndex2 > 3) {
		}
		else if(objectPressedName == GameStart.objectArray[GameStart.clues[GameStart.clueIndex2]+10].name && objectPressed)
		{
			if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
				objClue = GameStart.clueObject[1];
			else if(GameStart.rdmMode == 3)
				objClue = GameStart.wordArray[1];
			if(obj.transform.position.y < objClue.transform.position.y + 0.3 && obj.transform.position.x < objClue.transform.position.x + 0.3)
				obj.transform.rotation = new Quaternion(0f,0f,0f,0f);
			else
				moveObject(objClue, obj);
		}

		if(GameStart.clueIndex3 > 3) {
		}
		else if(objectPressedName == GameStart.objectArray[GameStart.clues[GameStart.clueIndex3]+20].name && objectPressed)
		{
			if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
				objClue = GameStart.clueObject[2];
			else if(GameStart.rdmMode == 3)
				objClue = GameStart.wordArray[2];
			if(obj.transform.position.y < objClue.transform.position.y + 0.3 && obj.transform.position.x < objClue.transform.position.x + 0.3)
				obj.transform.rotation = new Quaternion(0f,0f,0f,0f);
				//glowParts = (GameObject)Instantiate (Resources.Load("Glow Effect"), obj.transform.position, obj.transform.rotation);
			else
				moveObject(objClue, obj);

		}

		if(GameStart.clueIndex4 > 2) {
		}
		else if(objectPressedName == GameStart.objectArray[GameStart.clues[GameStart.clueIndex4]+30].name && objectPressed)
		{
			if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
				objClue = GameStart.clueObject[3];
			else if(GameStart.rdmMode == 3)
				objClue = GameStart.wordArray[3];
			if(obj.transform.position.y < objClue.transform.position.y + 0.3 && obj.transform.position.x < objClue.transform.position.x + 0.3)
				obj.transform.rotation = new Quaternion(0f,0f,0f,0f);
				//glowParts = (GameObject)Instantiate (Resources.Load("Glow Effect"), obj.transform.position, obj.transform.rotation);
			else
				moveObject(objClue, obj);
		}
		//Destroy (glowParts, 2f);
	}
	// Code to rotate, spin, show and hide an object
	public void moveObject(GameObject objectClue, GameObject objectClicked)
	{
		Transform objTransform = objectClicked.transform;
		Vector3 newPosition = objectClue.transform.position;
		
		// Disable clicking of moving hidden object
		objectClicked.GetComponent<Button> ().interactable = false;
		// Spam hint fix
		GameButtons.hintUsed2 = true;
		enlargeRoutine = enlargeObj (objTransform);
		StartCoroutine (enlargeRoutine);
		StartCoroutine ("stopEnlarge");
		StartCoroutine ("smallerDelay", objTransform);
		// Hide object clicked
		StartCoroutine ("destroyDelay", objectClicked);
	}
	IEnumerator destroyDelay(GameObject objectDestroy)
	{
		yield return new WaitForSeconds (delayDestroy);
		objectDestroy.SetActive(false);
		//GameButtons.hintUsed = false;
		GameButtons.hintUsed2 = false;
		objectPressed = false;
	}
	IEnumerator smallerDelay(Transform objTransform)
	{
		yield return new WaitForSeconds (0.5f);
		// Spinning animation
		objTransform.Rotate(0, 0, 1500f * Time.deltaTime, Space.World);
		// Move object animation
		objTransform.position = Vector3.Lerp(objTransform.position, objClue.transform.position, 3.5f * Time.deltaTime);
		// Resize object to small
		RectTransform objRt = (RectTransform)objTransform;
		RectTransform newRt = (RectTransform)objClue.transform;
		float newWidth = Mathf.Lerp(objRt.rect.width, newRt.rect.width, Time.deltaTime / 0.3f);
		float newHeight = Mathf.Lerp(objRt.rect.height, newRt.rect.height, Time.deltaTime / 0.3f);
		objRt.sizeDelta = new Vector2(newWidth, newHeight);

    	this.gameObject.GetComponent<Image>().CrossFadeAlpha(0.1f, 0.5f, false);
	}
	IEnumerator stopEnlarge ()
	{
		yield return new WaitForSeconds (0.5f);
		StopCoroutine (enlargeRoutine);
	}
	IEnumerator enlargeObj(Transform objTrans)
	{
		yield return new WaitForSeconds (0.0001f);
		// Resize object to large
		RectTransform objRt = (RectTransform)objTrans;
		float newWidth = Mathf.Lerp(objRt.rect.width, objRt.rect.width + 50, Time.deltaTime / 0.3f);
		float newHeight = Mathf.Lerp(objRt.rect.height, objRt.rect.height + 50, Time.deltaTime / 0.3f);
		objRt.sizeDelta = new Vector2(newWidth, newHeight);
	}
	IEnumerator delayUpdate(int clueIndex)
	{
		Quaternion zeroTrans = new Quaternion (0f,0f,0f,0f);
		yield return new WaitForSeconds(updateDelay);
		if (clueIndex == 1) {
			coins1 = (GameObject)Instantiate (Resources.Load ("Levels/coins"), objClue.transform.position, zeroTrans);
			coins1.transform.SetParent(GameObject.Find("Game Objects").transform);
			coins1.transform.localScale = new Vector3(1,1,1);
			coins1.name = "coins1";
			currentCoin[0] = newMoneyBns;
			objClue.SetActive(false);
		} else if (clueIndex == 2) {
			coins2 = (GameObject)Instantiate (Resources.Load("Levels/coins"), objClue.transform.position, zeroTrans);
			coins2.transform.SetParent(GameObject.Find("Game Objects").transform);
			coins2.transform.localScale = new Vector3(1,1,1);
			coins2.name = "coins2";
			currentCoin[1] = newMoneyBns;
			objClue.SetActive(false);
		}
		else if (clueIndex == 3) {
			coins3 = (GameObject)Instantiate (Resources.Load("Levels/coins"), objClue.transform.position, zeroTrans);
			coins3.transform.SetParent(GameObject.Find("Game Objects").transform);
			coins3.transform.localScale = new Vector3(1,1,1);
			coins3.name = "coins3";
			currentCoin[2] = newMoneyBns;
			objClue.SetActive(false);
		}
		else if (clueIndex == 4) {
			coins4 = (GameObject)Instantiate (Resources.Load("Levels/coins"), objClue.transform.position, zeroTrans);
			coins4.transform.SetParent(GameObject.Find("Game Objects").transform);
			coins4.transform.localScale = new Vector3(1,1,1);
			coins4.name = "coins4";
			currentCoin[3] = newMoneyBns;
			objClue.SetActive(false);
		}
	}
}