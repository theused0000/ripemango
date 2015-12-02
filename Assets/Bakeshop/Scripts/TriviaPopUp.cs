/// <summary>
/// TriviaPopUp.cs
/// Logic codes for pop-up trivia in Bakeshop scene and Game level scene
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TriviaPopUp : MonoBehaviour 
{
	// Sprite variable to be used to override existing sprite
	private Sprite newSprite;
	// GameObjects inside Bakeshop and Level scene
	private GameObject triviaPopUp;
	private GameObject imageBox;
	private GameObject titleText;
	private GameObject infoText;
	// Variable declarations to be used as container
	private Image decorSprite;
	private Text title;
	private Text info;
	void Start()
	{
		setGameObj();
		// Get components of image and text from existing Trivia gameobject inside scene
		decorSprite = imageBox.GetComponent<Image>();
		title = titleText.GetComponent<Text>();
		info = infoText.GetComponent<Text>();
	}
	public void setGameObj()
	{
		triviaPopUp = GameObject.Find("triviaPopUp(Clone)");
		imageBox = GameObject.Find("triviaImage");
		titleText = GameObject.Find("triviaTitle");
		infoText = GameObject.Find("triviaInfo");
		triviaPopUp.SetActive(false);
	}
	// When Decorative item is hit in bakeshop scene show trivia pop-up
	public void hit()
	{
		triviaPopUp.SetActive(true);
		triviaPopUp.GetComponent<CanvasGroup> ().alpha = 1;
		triviaPopUp.GetComponent<CanvasGroup> ().interactable = true;
		decorSprite.overrideSprite = (Sprite)Resources.Load("DecorsHD/"+DecorHit.currentDecor, typeof(Sprite));
		title.text = DecorsDb.currentTitle;
		info.text = DecorsDb.currentInfo;
	}
	// When Decorative item is hit in Level scene show trivia pop-up
	public void hitLevel()
	{
		if(ObjectPressed.objectPressed && LevelManager.playMode == "story" && DecorHit.currentDecor == ObjectPressed.objectPressedName2) {
			StartCoroutine("hitDelay");
		}
	}
	IEnumerator hitDelay()
	{
		// Number of seconds to delay before reading lines of code
		yield return new WaitForSeconds(1f);
		hit ();
		/*Debug.Log("decor hit!");
		triviaPopUp.SetActive(true);
		decorSprite.overrideSprite = (Sprite)Resources.Load("DecorsHD/"+DecorHit.currentDecor, typeof(Sprite));
		title.text = DecorsDb.currentTitle;
		info.text = DecorsDb.currentInfo;*/
	}
}
