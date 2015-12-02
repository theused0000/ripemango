using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class FurnShop : MonoBehaviour 
{
	public static Toggle dw, st, fl, f, p, ld, gr, sh, ft, kt, w, wd;
	// Strings
	private string dwName = "drawer", stName = "sideTable", flName = "floorLamp", fName = "floor", 
	pName = "portrait", ldName = "landscape", grName = "gasRange", shName = "shelf", ftName = "frontTable",
	ktName = "kitchenTable", wName = "wallpaper", wdName = "window";

	private int price;
	public static int priceID = 0;
	public static GameObject notif, furnDesign, purchaseBtn, useBtn;
	public static Text notifTxt, priceTxt;
	private List<Text> prices;
	public static string[] own = new string[]{"own1", "own2", "own3", "own4", "own5"};
	public static Image furnImg;
	public static CanvasGroup[] set;
	
	void Start ()
	{
		// Select Furnitures Toggle
		dw = GameObject.Find (dwName+"s").GetComponent<Toggle>();
		st = GameObject.Find (stName+"s").GetComponent<Toggle>();
		fl = GameObject.Find (flName+"s").GetComponent<Toggle>();
		f = GameObject.Find (fName+"s").GetComponent<Toggle>();
		p = GameObject.Find (pName+"s").GetComponent<Toggle>();
		ld = GameObject.Find (ldName+"s").GetComponent<Toggle>();
		gr = GameObject.Find (grName+"s").GetComponent<Toggle>();
		sh = GameObject.Find (shName+"s").GetComponent<Toggle>();
		ft = GameObject.Find (ftName+"s").GetComponent<Toggle>();
		kt = GameObject.Find (ktName+"s").GetComponent<Toggle>();
		w = GameObject.Find (wName+"s").GetComponent<Toggle>();
		wd = GameObject.Find (wdName+"s").GetComponent<Toggle>();

		// Notification
		notif = GameObject.Find("notif");
		notifTxt = GameObject.Find("notifTxt").GetComponent<Text>();
		notif.SetActive(false);
		prices = new List<Text>();
		for(int x = 0; x < 5; x++)
		{
			int y = x + 1;
			prices.Add(GameObject.Find("price"+y).GetComponent<Text>());
		}
		// Furniture preview UI
		purchaseBtn = GameObject.Find("purchaseBtn");
		useBtn = GameObject.Find("useBtn");
		priceTxt = GameObject.Find ("price").GetComponent<Text>();
		furnDesign = GameObject.Find ("furnDesign");
		furnImg = GameObject.Find ("furnImg").GetComponent<Image>();
		furnDesign.SetActive(false);
		set = new CanvasGroup[3];
		set [0] = GameObject.Find ("set1").GetComponent<CanvasGroup>();
		set [1] = GameObject.Find ("set2").GetComponent<CanvasGroup>();
		set [2] = GameObject.Find ("set3").GetComponent<CanvasGroup>();

		FurnShop.set [1].interactable = false;
		FurnShop.set [1].alpha = 0;
		FurnShop.set [1].blocksRaycasts = false;
		FurnShop.set [2].interactable = false;
		FurnShop.set [2].alpha = 0;
		FurnShop.set [2].blocksRaycasts = false;

		UnlockFurns.disableFurns ();
		Design.setPriceTag ();
	}
	void Update()
	{
		// Furninture Kind that is Selected
		if (dw.isOn) {
			Design.furnName = dwName;
			priceID = 6;
		} else if (st.isOn) {
			Design.furnName = stName;
			priceID = 7;
		} else if (fl.isOn) {
			Design.furnName = flName;
			priceID = 5;
		} else if (f.isOn) {
			Design.furnName = fName;
			priceID = 1;
		} else if (p.isOn) {
			Design.furnName = pName;
			priceID = 4;
		} else if (ld.isOn) {
			Design.furnName = ldName;
			priceID = 3;
		} else if (gr.isOn) {
			Design.furnName = grName;
			priceID = 11;
		} else if (sh.isOn) {
			Design.furnName = shName;
			priceID = 10;
		} else if (ft.isOn) {
			Design.furnName = ftName;
			priceID = 8;
		} else if (kt.isOn) {
			Design.furnName = ktName;
			priceID = 9;
		} else if (w.isOn) {
			Design.furnName = wName;
			priceID = 0;
		} else if (wd.isOn) {
			Design.furnName = wdName;
			priceID = 2;
		}
			
		// Loop for Changing furniture selection
		for (int x = 1; x < 6; x++)
		{
			int y = x - 1;
			GameObject selectFurn = GameObject.Find ("furn"+x);
			Image furnSprite = selectFurn.GetComponent<Image>();
			furnSprite.sprite = (Sprite)Resources.Load("BakeshopDesigns/"+Design.furnName+"s/"+Design.furnName+""+x, typeof(Sprite));
			prices[y].text = PlayerPrefs.GetString(Design.furnName+"Owned"+GameManager.num+Bakeshop.shop+x);
		}
	}
	public void buyFurn()
	{
		price = Design.priceTag [FurnShop.priceID, Design.furnID - 1];
		notif.GetComponent<CanvasGroup> ().alpha = 1;
		Debug.Log (prices[Design.furnID - 1].text);
		Debug.Log (price);
		Debug.Log (SelectPlayer.money);
		if(SelectPlayer.money >= price && PlayerPrefs.GetString (Design.furnName+"Owned"+GameManager.num+Bakeshop.shop+Design.furnID) != "Owned")
		{
			PlayerPrefs.SetString (Design.furnName+"Owned"+GameManager.num+Bakeshop.shop+Design.furnID, "Owned");
			SelectPlayer.money -= price;
			purchaseBtn.SetActive(false);
			useBtn.SetActive(true);
			priceTxt.text = "Owned";
			PlayerPrefs.SetInt("money"+GameManager.num, SelectPlayer.money);
		}
		else if(PlayerPrefs.GetString (Design.furnName+"Owned"+GameManager.num+Bakeshop.shop+Design.furnID) == "Owned")
		{
			notif.SetActive(true);
			notifTxt.text = "You already own this furniture.";
		}
		else
		{
			notif.SetActive(true);
			furnDesign.SetActive(false);
		}
	}
}