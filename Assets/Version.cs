using UnityEngine;
using System.Collections;

public class Version : MonoBehaviour {
	public string game;
	public string store;
	public static bool noAds = false;
	public GameObject premiumBtn;

	void Start () {
		if (game == "free") {
			noAds = false;
			premiumBtn.SetActive(false);
		} else if (game == "paid") {
			noAds = true;
			premiumBtn.SetActive(true);
		}
	}

	public void linkToPremium () {
		if (store == "googleplay") {
			Application.OpenURL ("linkToGooglePlayPremiumVersion");
		} else if (store == "amazon") {
			Application.OpenURL ("linkToAmazonPremiumVersion");
		}
	}
}
