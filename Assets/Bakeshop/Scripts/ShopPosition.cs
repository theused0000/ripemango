using UnityEngine;
using System.Collections;

public class ShopPosition : MonoBehaviour {
	public RectTransform bakeshopID;
	private Vector2 shopPos;
	public RectTransform[] shopRect;
	public GameObject[] shop;
	private int playerNum;

	void Start () {
		playerNum = PlayerPrefs.GetInt ("playerPlaying");

		Debug.Log ("Shop Num: "+PlayerPrefs.GetInt("ShopNum"+playerNum));

		if (PlayerPrefs.GetInt ("ShopNum" + playerNum) == 1 || PlayerPrefs.GetInt ("ShopNum" + playerNum) == 0) {
			shopPos = new Vector2(shopRect[0].anchoredPosition.x, shopRect[0].anchoredPosition.y);
			shop[0].SetActive(true);
		}
		
		for (int x = 1; x<5; x++) {
			int y = x+1;
			if (PlayerPrefs.GetInt ("ShopNum" + playerNum) == y) {
				shopPos = new Vector2(shopRect[x].anchoredPosition.x, shopRect[x].anchoredPosition.y);
				shop[x].SetActive(true);
			}
		}
		
		bakeshopID.anchoredPosition = shopPos;
	}
}
