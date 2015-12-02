using UnityEngine;
using System.Collections;

public class TapNotif : MonoBehaviour {
	public GameObject tapNotif;

	// Use this for initialization
	void OnEnable () {
		if (Application.loadedLevelName == "LevelStage" && PlayerPrefs.GetInt ("CoinNotif" + GameManager.num) != 1) {
			StartCoroutine ("popUpDelay");
		} else {
			tapNotif.SetActive(false);
		}
	}

	IEnumerator popUpDelay() {
		yield return new WaitForSeconds (2f);
		tapNotif.SetActive (true);
		if(Application.loadedLevelName == "LevelStage") {
			PlayerPrefs.SetInt("CoinNotif"+GameManager.num, 1);
		}
	}
}
