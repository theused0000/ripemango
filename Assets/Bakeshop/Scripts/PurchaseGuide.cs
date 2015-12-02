using UnityEngine;
using System.Collections;

public class PurchaseGuide : MonoBehaviour {
	public GameObject tapDesign, tapWall, tapPurchase, tapSet, tapSpecial, navNotif, tapPlay, tapStory, tapClose;

	void Start() {
		StartCoroutine ("showTapSpecial");
	}

	public void showTapClose () {
		if (PlayerPrefs.GetInt ("TapClose" + GameManager.num) < 1) {
			tapClose.SetActive(true);
			PlayerPrefs.SetInt("TapClose" + GameManager.num, 1);
		}
	}

	public void showTapPlay () {
		if (PlayerPrefs.GetInt ("TapPlay" + GameManager.num) < 1) {
			tapPlay.SetActive(true);
			PlayerPrefs.SetInt("TapPlay" + GameManager.num, 1);
		}
	}

	public void showTapStory () {
		if (PlayerPrefs.GetInt ("TapStory" + GameManager.num) < 1) {
			tapStory.SetActive(true);
			PlayerPrefs.SetInt("TapStory" + GameManager.num, 1);
		}
	}

	IEnumerator showTapSpecial () {
		yield return new WaitForSeconds (2f);
		if (PlayerPrefs.GetInt ("TapSpecial" + GameManager.num) < 1) {
			tapSpecial.SetActive (true);
			PlayerPrefs.SetInt ("TapSpecial"+GameManager.num, 1);
		}
	}

	public void showNavNotif () {
		if (PlayerPrefs.GetInt ("NavNotif" + GameManager.num) < 1) {
			navNotif.SetActive(true);
			PlayerPrefs.SetInt("NavNotif" + GameManager.num, 1);
		}
	}

	// Use this for initialization
	public void showTapDesign () {
		if (PlayerPrefs.GetInt ("PurchaseGuide1" + GameManager.num) < 1) {
			tapDesign.SetActive (true);
			PlayerPrefs.SetInt ("PurchaseGuide1"+GameManager.num, 1);
		}
	}
		
	public void showTapWall () {
		tapDesign.SetActive (false);
		if (PlayerPrefs.GetInt ("PurchaseGuide2" + GameManager.num) < 1) {
			tapWall.SetActive (true);
			PlayerPrefs.SetInt ("PurchaseGuide2" + GameManager.num, 1);
		}
	}

	public void showTapPurchase () {
		tapWall.SetActive (false);
		if (PlayerPrefs.GetInt ("PurchaseGuide3" + GameManager.num) < 1) {
			tapPurchase.SetActive (true);
			PlayerPrefs.SetInt ("PurchaseGuide3"+GameManager.num, 1);
		}
	}

	public void showTapSet () {
		tapPurchase.SetActive (false);
		if (PlayerPrefs.GetInt ("PurchaseGuide4" + GameManager.num) < 1) {
			tapSet.SetActive (true);
			PlayerPrefs.SetInt ("PurchaseGuide4"+GameManager.num, 1);
		}

	}
}