using UnityEngine;
using System.Collections;

public class ShowAds : MonoBehaviour {

	public static void InterstitialAd() {
		if (PlayerPrefs.GetInt ("CurrentLevel"+GameManager.num) % 3 == 0) {
			Debug.Log("Ads Interstitial");
			AdsorbAds.ShowInterstitialAd ();
		}
	}
}
