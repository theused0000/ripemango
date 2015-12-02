// Decor list Database
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class GameManager : MonoBehaviour 
{
	public static string[] allDecors;
	public static int num;
	private List<GameObject> objDecors;
	public static string[] furnNames;
	public Button b1, b2, b3, b4, b5;
	public GameObject levelTxtObj;
	public static string backdrop;
	public Animator shopAnim;
	public Text shopNumTxt, playerTxt;
	public GameObject hacks;
	public GameObject gameReminder, scoreTxt, cashTxt;
	public static bool reminder = false;
	public GameObject errorPopUp;

	void Start()
	{
		furnNames = new string[]{"bigDrawer", "smallDrawer", "floorLamp", "floor", "frame1", "frame3", 
			"oven", "shelf", "static", "frontTable", "rearTable", "wall", "window"};
		
		setNum();

		if (PlayerPrefs.GetString ("playerName" + GameManager.num) == "114710" || PlayerPrefs.GetString ("playerName" + GameManager.num) == "ripemango") {
			hacks.SetActive(true);
		}

		if (!reminder) {
			gameReminder.SetActive(true);
			scoreTxt.GetComponent<Text>().text = ""+string.Format("{0:#,###0}", PlayerPrefs.GetInt("score"+num));
			cashTxt.GetComponent<Text>().text = "$"+string.Format("{0:#,###0}", PlayerPrefs.GetInt("money"+num));
			reminder = true;
		}

		showShopNum ();
		setTutorial ();
		decorList();
		Debug.Log (allDecors.Length);
		objDecors = new List<GameObject>();
		objDecors.AddRange(GameObject.FindGameObjectsWithTag("Decoratives"));

		for(int x=0; x<objDecors.Count; x++)
		{
			Image objSprite = objDecors[x].GetComponent<Image>();
			objSprite.sprite = (Sprite)Resources.Load("DecorsHD/"+objDecors[x].name, typeof(Sprite));
		}
	}
	private void setNum()
	{
		if(PlayerPrefs.GetInt("playerPlaying") == 1) {
			num = 1;
		}
		else if (PlayerPrefs.GetInt("playerPlaying") == 2) {
			num = 2;
		}
		else if (PlayerPrefs.GetInt("playerPlaying") == 3) {
			num = 3;
		}
		else if (PlayerPrefs.GetInt("playerPlaying") == 4) {
			num = 4;
		}
		else if (PlayerPrefs.GetInt("playerPlaying") == 5) {
			num = 5;
		}
	}
	public void decorList()
	{
		allDecors = new string[] {
			"wall_clock",  "moneybox",  "telephone",  "chandelier",  "icing_pipe",  "sun_ornament",  "radio",  "glass_container",

			"thermometer",  "bottle_stopper",  "hourglass",  "mirror",  "plate",  "samovar",  "wooden_fork",  "wooden_spoon",

			"measuring_glass",  "teapot",  "vase",  "cupcake_cases",  "muffin_tray",  "spatula",  "mittens",  "whisk",

			"pear_shaped_pot",  "tureen",  "kettle",  "beating_bowl",  "pastry_brush",  "blackboard_sign",  "chalk_bucket",

			"pastry_cutter",  "utensil_jar",  "flower_mug",  "faucet",  "honey_jar",  "pie_pans",

			"weighing_scale",  "mini_ferris_wheel",  "rolling_pin",  "measuring_spoons",  "coffee_mill",  "vintage_grater",  "measuring_cups",

			"squeezer",  "cookie_jar",  "mixer",  "cake_stand",  "tea_cups",  "perfume_bottle",  "pitcher",  "sugar_bowl",

			"blender",  "basket",  "sifter",  "kerosene_lamp",  "cookie_cutter", "palette_knife", "bench_scraper", "bell"
		};
	}

	public void showShop() {
		b1.interactable = true;
		b2.interactable = true;
		b3.interactable = true;
		b4.interactable = true;
		b5.interactable = true;

		if (LevelManager.currentLevel > 59 && LevelManager.currentLevel < 120) {
			b3.interactable = false;
			b4.interactable = false;
			b5.interactable = false;
			if (PlayerPrefs.GetString ("sold2" + GameManager.num) != "sold") {
				b2.interactable = false;
			}
		} else if (LevelManager.currentLevel > 119 && LevelManager.currentLevel < 180) {
			b4.interactable = false;
			b5.interactable = false;
			if(PlayerPrefs.GetString("sold3"+GameManager.num) != "sold") {
				b3.interactable = false;
			}
		} else if (LevelManager.currentLevel > 179 && LevelManager.currentLevel < 240) {
			b5.interactable = false;
			if(PlayerPrefs.GetString("sold4"+GameManager.num) != "sold") {
				b4.interactable = false;
			}
		} else if (LevelManager.currentLevel < 60) {
			b2.interactable = false;
			b3.interactable = false;
			b4.interactable = false;
			b5.interactable = false;
		}

		if(PlayerPrefs.GetString("sold5"+GameManager.num) != "sold") {
			b5.interactable = false;
		}
	}

	public void showLevelTxt() {
		levelTxtObj.SetActive(true);
	}

	public void setTutorial() {
		if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "DoneTutorial") {
			LevelManager.currentLevel = LevelManager.currentLevel;
		} else if (PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num) == 300 && 
		           PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "GameEnd") {
			Application.LoadLevel ("Tutorial");
		} else if (PlayerPrefs.GetInt ("TutorialDone" + num) == 0) {
			Application.LoadLevel ("Tutorial");
		} else if (PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num) == 60 && 
		           PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop3") {
		    Application.LoadLevel ("Tutorial");
		} else if (PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num) == 120 && 
		           PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop4") {
			Application.LoadLevel ("Tutorial");
		} else if (PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num) == 180 && 
		           PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop5") {
			Application.LoadLevel ("Tutorial");
		} else if (PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num) == 240 && 
		           PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop6") {
			Application.LoadLevel ("Tutorial");
		}

	}

	public void showShopNum() {
		string shopTxt = "";
		if (PlayerPrefs.GetInt ("ShopNum" + GameManager.num) == 1 || PlayerPrefs.GetInt ("ShopNum" + GameManager.num) == 0) {
			shopTxt = "Pan de Felicia";
		} else if (PlayerPrefs.GetInt ("ShopNum" + GameManager.num) == 2) {
			shopTxt = "Jehanna";
		} else if (PlayerPrefs.GetInt ("ShopNum" + GameManager.num) == 3) {
			shopTxt = "Dublanc";
		} else if (PlayerPrefs.GetInt ("ShopNum" + GameManager.num) == 4) {
			shopTxt = "Francia";
		} else if (PlayerPrefs.GetInt ("ShopNum" + GameManager.num) == 5) {
			shopTxt = "Laxbourg";
		}

		playerTxt.text = shopTxt;
		shopNumTxt.text = "Welcome to "+shopTxt+".";
		shopAnim.Play ("shopNum");
	}

	public void buyBakeshop(int soldNum) {
		int shopPrice = 10000 + soldNum * 1000;

		if (SelectPlayer.money >= shopPrice) {
			PlayerPrefs.SetString ("sold" + soldNum + num, "sold");
			SelectPlayer.money -= shopPrice;
			PlayerPrefs.SetInt ("money" + GameManager.num, SelectPlayer.money);

			PlayerPrefs.SetInt ("ShopNum"+GameManager.num, soldNum);
			Bakeshop.shop = soldNum;

			Application.LoadLevel(Application.loadedLevelName);
		} else {
			errorPopUp.SetActive(true);
		}
	}
}