using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Bakeshop : MonoBehaviour
{
	public static List<GameObject> furnitures;
	public static int shop = 1;
	private Animator shopTransition;
	public static List<GameObject> tiles;
	public Text moneyTxt, scoreTxt, decorTxt, levelTxt, cash;

	void Start()
	{
		tiles = new List<GameObject>();
		tiles.AddRange(GameObject.FindGameObjectsWithTag("Wallpaper"));
		shopTransition = GameObject.Find ("Furn_Decors").GetComponent<Animator>();
		if(PlayerPrefs.GetInt("ShopNum"+GameManager.num) == 0) {
			shop = 1;
		} else {
			shop = PlayerPrefs.GetInt("ShopNum"+GameManager.num);
		}
		Debug.Log ("Shop Number: "+shop);
		
		//shop = PlayerPrefs.GetInt ("ShopNum"+GameManager.num);
		setFurns ();
	}

	public void shopID(int shopNum) {
		PlayerPrefs.SetInt ("ShopNum"+GameManager.num, shopNum);
		shop = shopNum;
		//StartCoroutine ("setDecors");
		//shopTransition.Play ("BakeshopTransition");
		Debug.Log ("Shop Num: "+PlayerPrefs.GetInt("ShopNum"+GameManager.num));
	}

	IEnumerator setDecors()
	{
		yield return new WaitForSeconds (1f);
		DecorsDb.setDecors ();
		setFurns ();
	}

	public void setFurns()
	{
		furnitures = new List<GameObject>();
		furnitures.AddRange(GameObject.FindGameObjectsWithTag("Furnitures"));
		for(int x = 0; x < furnitures.Count; x++)
		{
			GameObject setFurn = GameObject.Find (furnitures[x].name);
			Image furnSprite = setFurn.GetComponent<Image>();
			furnSprite.sprite = (Sprite)Resources.Load("BakeshopDesigns/"+furnitures[x].name+"s/"
			                    +furnitures[x].name+""+PlayerPrefs.GetInt(furnitures[x].name
			                    +GameManager.num+Bakeshop.shop), typeof(Sprite));
		}
	}
	public void updateMoney() {
		SelectPlayer.money = PlayerPrefs.GetInt("money"+GameManager.num);
		// Money
		cash.text = " $"+string.Format("{0:#,###0}", SelectPlayer.money);
	}

	public void updateStats() {
		SelectPlayer.money = PlayerPrefs.GetInt("money"+GameManager.num);
		// Money
		moneyTxt.text = "Cash: $"+string.Format("{0:#,###0}", SelectPlayer.money);
		// Score
		scoreTxt.text = "Score: "+string.Format("{0:#,###0}", SelectPlayer.score);
		// Decors
		int decors = 0;
		for (int x = 0; x < GameManager.allDecors.Length; x++)
		{
			if(PlayerPrefs.GetInt(GameManager.allDecors[x]+""+GameManager.num+Bakeshop.shop) == 1)
			{
				decors++;
			}
		}
		decorTxt.text = "Decoratives: "+decors+"/60";
		// Level
		levelTxt.text = "Level: "+LevelManager.currentLevel;
	}
}
