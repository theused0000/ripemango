using UnityEngine;
using System.Collections;

public class NewShopGuide : MonoBehaviour {
	public GameObject tapFelicia, tapBuy;

	public void showTapFelicia() {
		if (PlayerPrefs.GetInt ("NewShopGuide1" + GameManager.num) < 1 && LevelManager.currentLevel == 60) {
			tapFelicia.SetActive (true);
			PlayerPrefs.SetInt("NewShopGuide1" + GameManager.num, 1);
		}
	}

	public void showTapBuy() {
		if (PlayerPrefs.GetInt ("NewShopGuide2" + GameManager.num) < 1 && LevelManager.currentLevel == 60) {
			tapBuy.SetActive (true);
			PlayerPrefs.SetInt("NewShopGuide2" + GameManager.num, 1);
		}
	}
}
