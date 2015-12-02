using UnityEngine;
using System.Collections;

public class UnlockText : MonoBehaviour {
	public GameObject fTxt, wdTxt, ldTxt, pTxt, flTxt, dwTxt, stTxt, ftTxt, ktTxt, shTxt, grTxt;
	public GameObject shop2Txt, shop3Txt, shop4Txt, shop5Txt;
	public GameObject buy2, buy3, buy4, buy5,
			  price2, price3, price4, price5;

	public void SetLockedFurns() {
		if(LevelManager.currentLevel > 5 && LevelManager.currentLevel < 12 ) {
			fTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 11 && LevelManager.currentLevel < 16) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 15 && LevelManager.currentLevel < 20) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 19 && LevelManager.currentLevel < 25) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 24 && LevelManager.currentLevel < 35) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 34 && LevelManager.currentLevel < 42) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
			dwTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 41 && LevelManager.currentLevel < 50) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
			dwTxt.SetActive(false);
			stTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 49 && LevelManager.currentLevel < 58) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
			dwTxt.SetActive(false);
			stTxt.SetActive(false);
			ftTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 57 && LevelManager.currentLevel < 67) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
			dwTxt.SetActive(false);
			stTxt.SetActive(false);
			ftTxt.SetActive(false);
			ktTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 66 && LevelManager.currentLevel < 70) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
			dwTxt.SetActive(false);
			stTxt.SetActive(false);
			ftTxt.SetActive(false);
			ktTxt.SetActive(false);
			shTxt.SetActive(false);
		} else if(LevelManager.currentLevel > 69) {
			fTxt.SetActive(false);
			wdTxt.SetActive(false);
			ldTxt.SetActive(false);
			pTxt.SetActive(false);
			flTxt.SetActive(false);
			dwTxt.SetActive(false);
			stTxt.SetActive(false);
			ftTxt.SetActive(false);
			ktTxt.SetActive(false);
			shTxt.SetActive(false);
			grTxt.SetActive(false);
		}
	}

	public void SetLockedShops () {
		if(LevelManager.currentLevel > 59 && LevelManager.currentLevel < 120) {
			shop2Txt.SetActive(false);
			if(PlayerPrefs.GetString("sold2"+GameManager.num) != "sold") {
				buy2.SetActive(true);
				price2.SetActive(true);
			} else {
				buy2.SetActive(false);
				price2.SetActive(false);
			}
		} else if(LevelManager.currentLevel > 119 && LevelManager.currentLevel < 180 ) {
			shop2Txt.SetActive(false);
			shop3Txt.SetActive(false);
			if(PlayerPrefs.GetString("sold3"+GameManager.num) != "sold") {
				buy3.SetActive(true);
				price3.SetActive(true);
			} else {
				buy3.SetActive(false);
				price3.SetActive(false);
			}
		} else if(LevelManager.currentLevel > 179 && LevelManager.currentLevel < 240) {
			shop2Txt.SetActive(false);
			shop3Txt.SetActive(false);
			shop4Txt.SetActive(false);
			if(PlayerPrefs.GetString("sold4"+GameManager.num) != "sold") {
				buy4.SetActive(true);
				price4.SetActive(true);
			} else {
				buy4.SetActive(false);
				price4.SetActive(false);
			}
		} else if(LevelManager.currentLevel > 239) {
			shop2Txt.SetActive(false);
			shop3Txt.SetActive(false);
			shop4Txt.SetActive(false);
			shop5Txt.SetActive(false);
			if(PlayerPrefs.GetString("sold5"+GameManager.num) != "sold") {
				buy5.SetActive(true);
				price5.SetActive(true);
			} else {
				buy5.SetActive(false);
				price5.SetActive(false);
			}
		}
	}
}
