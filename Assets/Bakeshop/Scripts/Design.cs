using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Design : MonoBehaviour
{
	private GameObject furn; // furniture
	public static int furnID;
	public static string furnName = "cabinet";
	private int price;
	public static int[,] priceTag = new int[12,5];

	public void changeDesign()
	{
		FurnShop.furnDesign.SetActive(true);
		FurnShop.furnDesign.GetComponent<CanvasGroup>().alpha = 1;
		FurnShop.furnImg.sprite = (Sprite)Resources.Load("BakeshopDesigns/"+furnName+"s/"+furnName+""+furnID, typeof(Sprite));
		GameObject.Find("furnTxt").GetComponent<Text>().text = ShopDetails.name[FurnShop.priceID,furnID-1];
		GameObject.Find("details").GetComponent<Text>().text = ShopDetails.details[FurnShop.priceID,furnID-1];

		if (PlayerPrefs.GetString(Design.furnName+"Owned"+GameManager.num+Bakeshop.shop+furnID) != "Owned") {
			FurnShop.purchaseBtn.SetActive(true);
			FurnShop.useBtn.SetActive(false);
			FurnShop.priceTxt.text = "Price: $"+priceTag[FurnShop.priceID,furnID-1];
		} else {
			FurnShop.purchaseBtn.SetActive(false);
			FurnShop.useBtn.SetActive(true);
			FurnShop.priceTxt.text = "Owned";
		}

		if (furnName == "wallpaper") {
			FurnShop.furnImg.type = Image.Type.Tiled;
		} else {
			FurnShop.furnImg.type = Image.Type.Simple;
		}
	}

	public void setDesign() {
		furn = GameObject.Find (furnName);
		Image furnSprite = furn.GetComponent<Image>();
		furnSprite.sprite = (Sprite)Resources.Load("BakeshopDesigns/"
		           +furnName+"s/"+furnName+""+furnID, typeof(Sprite));
		PlayerPrefs.SetInt (furnName+GameManager.num+Bakeshop.shop, furnID);
	}

	public void setFurnID(int num) {
		furnID = num;
	}

	public static void setPriceTag() {
		for (int x = 0; x < 5; x++) {
			priceTag [0,x] = 36 + ((36/2)*x);
			priceTag [1,x] = 180 + ((180/2)*x);
			priceTag [2,x] = 216 + ((216/2)*x);
			priceTag [3,x] = 242 + ((242/2)*x); // Temporary
			priceTag [4,x] = 268 + ((268/2)*x); // Temporary
			priceTag [5,x] = 275 + ((275/2)*x);
			priceTag [6,x] = 550 + ((550/2)*x);
			priceTag [7,x] = 620 + ((620/2)*x); // Changed
			priceTag [8,x] = 750 + ((750/2)*x);
			priceTag [9,x] = 880 + ((880/2)*x);
			priceTag [10,x] = 1067 + ((1067/2)*x);
			priceTag [11,x] = 1573 + ((1573/2)*x);
		}
	}
}