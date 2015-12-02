using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TutorialManager : MonoBehaviour
{
	public GameObject charImg, charPopUp, dialogBox, specialItem, navButtons, store, purchase, 
					  hintArrow, itemArrow, sItemArrow, storeArrow, wpArrow, purchaseArrow, playArrow;
	public Image backdrop;
	public Text name, dialog, charDialog;
	private int id = 0;
	private string[] dialogs, names;
	private string playerName, newStory, updatedText;
	private Text updatedDialog;
	private Outside outStory;
	private Bakeshop1 shopStory1;
	private Level1 levelStory1;
	private Bakeshop2 shopStory2;
	private Bakeshop3 shopStory3;
	private Bakeshop4 shopStory4;
	private Bakeshop5 shopStory5;
	private Bakeshop6 shopStory6;
	private GameEnd gameEnd;
	private bool textElement, pinchZoom;
	public static bool typing;
	public Animator zoom;

	void Start() {
		playerName = PlayerPrefs.GetString ("playerName" + GameManager.num);
		changeStory ();
		changeSpeaker ();
	}

	private void setOutsideStory () {
		outStory = new Outside (names, dialogs, playerName);
		names = outStory.getNames ();
		dialogs = outStory.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/street", typeof(Sprite));
		newStory = "Bakeshop1";
	}

	private void setBakeshopStory1 () {
		shopStory1 = new Bakeshop1 (names, dialogs, playerName);
		names = shopStory1.getNames ();
		dialogs = shopStory1.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/bakeshop", typeof(Sprite));
		newStory = "Level1";
	}

	private void setLevelStory1 () {
		levelStory1 = new Level1 (names, dialogs, playerName);
		names = levelStory1.getNames ();
		dialogs = levelStory1.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/level1", typeof(Sprite));
		newStory = "PlayLevel1";
	}

	private void setBakeshopStory2 () {
		shopStory2 = new Bakeshop2 (names, dialogs, playerName);
		names = shopStory2.getNames ();
		dialogs = shopStory2.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/bakeshop", typeof(Sprite));
		newStory = "PlayLevel2";
	}

	private void setBakeshopStory3 () {
		shopStory3 = new Bakeshop3 (names, dialogs, playerName);
		names = shopStory3.getNames ();
		dialogs = shopStory3.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/street", typeof(Sprite));
		newStory = "Bakeshop4";
	}

	private void setBakeshopStory4 () {
		shopStory4 = new Bakeshop4 (names, dialogs, playerName);
		names = shopStory4.getNames ();
		dialogs = shopStory4.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/street", typeof(Sprite));
		newStory = "Bakeshop5";
	}

	private void setBakeshopStory5 () {
		shopStory5 = new Bakeshop5 (names, dialogs, playerName);
		names = shopStory5.getNames ();
		dialogs = shopStory5.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/street", typeof(Sprite));
		newStory = "Bakeshop6";
	} 

	private void setBakeshopStory6 () {
		shopStory6 = new Bakeshop6 (names, dialogs, playerName);
		names = shopStory6.getNames ();
		dialogs = shopStory6.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/street", typeof(Sprite));
		newStory = "GameEnd";
	}

	private void setGameEnd () {
		gameEnd = new GameEnd (names, dialogs, playerName);
		names = gameEnd.getNames ();
		dialogs = gameEnd.getDialogs ();
		backdrop.sprite = (Sprite)Resources.Load("Tutorial/street", typeof(Sprite));
		newStory = "DoneTutorial";
	}

	private void changeStory () {
		if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "PlayLevel1") {
			LevelManager.currentLevel = PlayerPrefs.GetInt ("CurrentLevel" + GameManager.num);
			LevelManager.currentLevel++;
			LevelManager.playMode = "story";
			PlayerPrefs.SetString ("Backdrop" + GameManager.num, "PlayLevel2");
			Application.LoadLevel ("LevelStage");
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop1") {
			setBakeshopStory1 ();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Level1") {
			setLevelStory1 ();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop2") {
			setBakeshopStory2();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop3") {
			setBakeshopStory3();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop4") {
			setBakeshopStory4();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop5") {
			setBakeshopStory5();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "Bakeshop6") {
			setBakeshopStory6();
		} else if (PlayerPrefs.GetString ("Backdrop" + GameManager.num) == "GameEnd") {
			setGameEnd();
		} else {
			setOutsideStory();
		}
	}

	public void skipTutorial() {
		if(textElement == false)
			AutoText.stopTypeWriter (dialog);
		else
			AutoText.stopTypeWriter (charDialog);

		string storyPlace = PlayerPrefs.GetString ("Backdrop" + GameManager.num);

		PlayerPrefs.SetString("Backdrop"+GameManager.num, newStory);
		changeStory ();
		id = 0;
		changeSpeaker();
		if(storyPlace == "Level1") {
			PlayerPrefs.SetInt("TutorialDone"+GameManager.num, 1);
			PlayerPrefs.SetString("Backdrop"+GameManager.num, "Bakeshop3");
			newStory = "Bakeshop3";
			Application.LoadLevel("LevelStage");
		} else if(storyPlace == "Bakeshop3" || storyPlace == "Bakeshop4" || storyPlace == "Bakeshop5" || 
		          storyPlace == "Bakeshop6" || storyPlace == "GameEnd") {
			Application.LoadLevel("Bakeshop");
		}
	}
	
	public void setDialog() {
		if(textElement == false)
			AutoText.stopTypeWriter (dialog);
		else
			AutoText.stopTypeWriter (charDialog);

		string storyPlace = PlayerPrefs.GetString ("Backdrop" + GameManager.num);

		if (id == dialogs.Length - 1 && !typing) {
			PlayerPrefs.SetString("Backdrop"+GameManager.num, newStory);
			changeStory ();
			id = 0;
			changeSpeaker();
			if(storyPlace == "Level1") {
				PlayerPrefs.SetInt("TutorialDone"+GameManager.num, 1);
				PlayerPrefs.SetString("Backdrop"+GameManager.num, "Bakeshop3");
				newStory = "Bakeshop3";
				Application.LoadLevel("LevelStage");
			} else if(storyPlace == "Bakeshop3" || storyPlace == "Bakeshop4" || storyPlace == "Bakeshop5" || 
			          storyPlace == "Bakeshop6" || storyPlace == "GameEnd") {
				Application.LoadLevel("Bakeshop");
			}
		} else {
			if(typing) {
				displayDialog();
				typing = false;
			} else {
				id++;
				changeSpeaker();
			}
		}

		storyPlace = PlayerPrefs.GetString ("Backdrop" + GameManager.num);

		if (storyPlace == "" || storyPlace == "Bakeshop1") {
			if (names [id] == "Felicia") {
				charImg.SetActive (true);
				Debug.Log ("Runned");
			}
		} else if (storyPlace == "Bakeshop3") {
			if (names [id] == "Felicia") {
				charImg.SetActive (true);
			} else if (id == 13) {
				charImg.SetActive (false);
				backdrop.sprite = (Sprite)Resources.Load ("Tutorial/newBakeshop", typeof(Sprite));
			}
		} else if (storyPlace == "Bakeshop4") {
			if (names [id] == "Felicia") {
				charImg.SetActive (true);
			} else if (id == 8) {
				charImg.SetActive (false);
				backdrop.sprite = (Sprite)Resources.Load ("Tutorial/newBakeshop", typeof(Sprite));
			}
		} else if (storyPlace == "Bakeshop5") {
			if (names [id] == "Felicia") {
				charImg.SetActive (true);
			} else if (id == 8) {
				charImg.SetActive (false);
				backdrop.sprite = (Sprite)Resources.Load ("Tutorial/newBakeshop", typeof(Sprite));
			}
		} else if (storyPlace == "Bakeshop6") {
			if (names [id] == "Felicia") {
				charImg.SetActive (true);
			} else if (id == 8) {
				charImg.SetActive (false);
				backdrop.sprite = (Sprite)Resources.Load ("Tutorial/newBakeshop", typeof(Sprite));
			}
		} else if (storyPlace == "GameEnd") {
			if (names [id] == "Felicia") {
				charImg.SetActive (true);
			}
		}
	}

	private float typeSpeed = 0;

	public void changeSpeaker() {

		if (names [id] == playerName) {
			typeSpeed = 0.5f;
		} else {
			typeSpeed = 2f;
		}

		string storyPlace = PlayerPrefs.GetString ("Backdrop" + GameManager.num);
		Debug.Log (storyPlace);
		if (storyPlace == "Level1") {
			charImg.SetActive (false);
			dialogBox.SetActive (false);
			charPopUp.SetActive (true);

			charDialog.text = "";
			updatedText = dialogs[id];
			AutoText.TypeText(charDialog, updatedText, 2f);
			textElement = true;

			if(id == 1) {
				itemArrow.SetActive(true);
			}else if(id == 3) {
				itemArrow.SetActive(false);
			} else if(id == 5) {
				hintArrow.SetActive(true);
			} else if(id == 6) {
				hintArrow.SetActive(false);
				zoom.Play("zoom");
			}
		} /*else if(storyPlace == "Bakeshop2") {
			charImg.SetActive(false);
			dialogBox.SetActive(false);
			charPopUp.SetActive(true);

			charDialog.text = "";
			updatedText = dialogs[id];
			AutoText.TypeText(charDialog, updatedText, 2f);
			textElement = true;

			if(id == 2) {
				specialItem.SetActive(true);
				sItemArrow.SetActive(true);
			} else if(id == 3) {
				sItemArrow.SetActive(false);
				navButtons.SetActive(true);
				storeArrow.SetActive(true);
			} else if(id == 4) {
				navButtons.SetActive(false);
				storeArrow.SetActive(false);
				store.SetActive(true);
				wpArrow.SetActive(true);
			} else if(id == 6) {
				store.SetActive(false);
				wpArrow.SetActive(false);
				purchase.SetActive(true);
				purchaseArrow.SetActive(true);
			} else if(id == 7) {
				purchase.SetActive(false);
				purchaseArrow.SetActive(false);
				navButtons.SetActive(true);
				playArrow.SetActive(true);
			}
		}*/ else {
			dialog.text = "";
			updatedText = dialogs [id];
			if(dialog.IsActive()) {
				AutoText.TypeText(dialog, updatedText, 2f);
			}
			textElement = false;
		}
		name.text = names [id];
	}

	public void displayDialog() {
		
		string storyPlace = PlayerPrefs.GetString ("Backdrop" + GameManager.num);
		Debug.Log (storyPlace);

		if (storyPlace == "Level1") {
			charDialog.text = dialogs[id];
		}/* else if(storyPlace == "Bakeshop2") {
			charDialog.text = dialogs[id];
		}*/ else {
			dialog.text = dialogs[id];
		}
		name.text = names [id];
	}
}