using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RewardAds : MonoBehaviour {

	void OnEnable() {
		AdsorbEvents.adsorbOnInterstitialAdsAvailable += this.adsorbOnInterstitialAdsAvailable;
		AdsorbEvents.adsorbOnInterstitialAdDismissed += this.adsorbOnInterstitialAdDismissed;
		AdsorbEvents.adsorbOnInterstitialAdFailed += this.adsorbOnInterstitialAdFailed;

		AdsorbEvents.adsorbOnHelperRewardedAdReady += this.adsorbOnHelperRewardedAdReady;
		AdsorbEvents.adsorbOnHelperRewardedAdUnavailable += this.adsorbOnHelperRewardedAdUnavailable;
		AdsorbEvents.adsorbOnHelperRewardedAdDismissed += this.adsorbOnHelperRewardedAdDismissed;
		AdsorbEvents.adsorbOnHelperRewardedAdFailed += this.adsorbOnHelperRewardedAdFailed;
		AdsorbEvents.adsorbOnHelperRewardGranted += this.adsorbOnHelperRewardGranted;

		AdsorbEvents.adsorbOnSuccessRewardedAdReady += this.adsorbOnSuccessRewardedAdReady;
		AdsorbEvents.adsorbOnSuccessRewardedAdUnavailable += this.adsorbOnSuccessRewardedAdUnavailable;
		AdsorbEvents.adsorbOnSuccessRewardedAdDismissed += this.adsorbOnSuccessRewardedAdDismissed;
		AdsorbEvents.adsorbOnSuccessRewardedAdFailed += this.adsorbOnSuccessRewardedAdFailed;
		AdsorbEvents.adsorbOnSuccessRewardGranted += this.adsorbOnSuccessRewardGranted;
	}

	void OnDisable() {
		AdsorbEvents.adsorbOnInterstitialAdsAvailable -= this.adsorbOnInterstitialAdsAvailable;
		AdsorbEvents.adsorbOnInterstitialAdDismissed -= this.adsorbOnInterstitialAdDismissed;
		AdsorbEvents.adsorbOnInterstitialAdFailed -= this.adsorbOnInterstitialAdFailed;
		
		AdsorbEvents.adsorbOnHelperRewardedAdReady -= this.adsorbOnHelperRewardedAdReady;
		AdsorbEvents.adsorbOnHelperRewardedAdUnavailable -= this.adsorbOnHelperRewardedAdUnavailable;
		AdsorbEvents.adsorbOnHelperRewardedAdDismissed -= this.adsorbOnHelperRewardedAdDismissed;
		AdsorbEvents.adsorbOnHelperRewardedAdFailed -= this.adsorbOnHelperRewardedAdFailed;
		AdsorbEvents.adsorbOnHelperRewardGranted -= this.adsorbOnHelperRewardGranted;
		
		AdsorbEvents.adsorbOnSuccessRewardedAdReady -= this.adsorbOnSuccessRewardedAdReady;
		AdsorbEvents.adsorbOnSuccessRewardedAdUnavailable -= this.adsorbOnSuccessRewardedAdUnavailable;
		AdsorbEvents.adsorbOnSuccessRewardedAdDismissed -= this.adsorbOnSuccessRewardedAdDismissed;
		AdsorbEvents.adsorbOnSuccessRewardedAdFailed -= this.adsorbOnSuccessRewardedAdFailed;
		AdsorbEvents.adsorbOnSuccessRewardGranted -= this.adsorbOnSuccessRewardGranted;
	}

	public void adsorbOnInterstitialAdsAvailable()
	{
		// Interstitial ads available
	}
	
	public void adsorbOnInterstitialAdDismissed()
	{
		// Interstitial ad dismissed
		/*if(Application.loadedLevelName == "LevelStage")
			AdsorbAds.ShowSuccessAd (null, "successFilter");*/
	}
	
	public void adsorbOnInterstitialAdFailed()
	{
		// Interstitial ad failed
		// Note that adsorbOnInterstitialAdDismissed will be called as well
	}
	
	public void adsorbOnHelperRewardedAdReady(string filterName)
	{
		// Helper ad loaded and ready to show
		
		//AdsorbAds.ShowHelperAd(null, filterName);    // Show loaded video, for example
	}
	
	public void adsorbOnHelperRewardedAdUnavailable(string filterName)
	{
		// Helper ad unavailable
	}
	
	public void adsorbOnHelperRewardedAdDismissed(string filterName)
	{
		// Helper ad dismissed
		GameButtons.loadAds.GetComponent<Button> ().interactable = true;
		AdsorbAds.LoadHelperAd ("Refill Hint?", "Watch a short message to get extra", "3 hints", "Tap for more Hints", false);
	}
	
	public void adsorbOnHelperRewardedAdFailed(string filterName)
	{
		// Helper ad failed
		GameButtons.loadAds.GetComponent<Button> ().interactable = true;
	}
	
	public void adsorbOnHelperRewardGranted(string filterName)
	{
		Debug.Log ("adsorbOnHelperRewardGranted");
		// Reward granted for success ad
		GameButtons.hintCount = 3;
		GameButtons.loadAds.SetActive (false);
		GameButtons.loadAds.GetComponent<Button> ().interactable = true;
		GameButtons.hintLeft.text = 3 + "";

		AdsorbAds.LoadHelperAd ("Refill Hint?", "Watch a short message to get extra", "3 hints", "Tap for more Hints", false);
	}

	public void adsorbOnSuccessRewardedAdReady(string filterName)
	{
		// Rewarded ad loaded and ready to show
		//AdsorbAds.ShowSuccessAd(null, filterName);    // Show loaded video, for example
	}
	
	public void adsorbOnSuccessRewardedAdUnavailable(string filterName)
	{
		// Rewarded ad unavailable
		Debug.Log("Adsorb Example - adsorbOnSuccessRewardedAdUnavailable");
		//mStatusText = "Unavailable";
	}
	
	public void adsorbOnSuccessRewardedAdDismissed(string filterName)
	{
		// Rewarded ad dismissed
	}
	
	public void adsorbOnSuccessRewardedAdFailed(string filterName)
	{
		// Rewarded ad failed
	}

	public void adsorbOnSuccessRewardGranted(string filterName)
	{
		// Reward granted for success ad
		SelectPlayer.score = GameStart.rewardScore;
		SelectPlayer.money = GameStart.rewardMoney;
		UpdateDbase.updateDatabase();
		UpdateDbase.updateScore();
		UpdateDbase.updateMoney();
	}
}