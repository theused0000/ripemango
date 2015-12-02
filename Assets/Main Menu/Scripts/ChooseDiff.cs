/// <summary>
/// ChooseDiff.cs
/// Handles difficulty variable in GameStart.cs when player choose the difficulty
/// </summary>
using UnityEngine;
using System.Collections;

public class ChooseDiff : MonoBehaviour {
	public CanvasGroup myCanvasGroup;
	private GameObject canvasGameObj;
	private bool fadeIn = false;
	private bool fadeOut = false;
	private AudioSource clickSound;
	void Start()
	{
		clickSound = GameObject.Find ("clickSound").GetComponent<AudioSource> ();
	}
	void Update()
	{
		if(fadeIn)
		{
			myCanvasGroup = canvasGameObj.GetComponent<CanvasGroup>();
			myCanvasGroup.alpha = myCanvasGroup.alpha + Time.deltaTime *4f;
			myCanvasGroup.interactable = false;
			if(myCanvasGroup.alpha >= 1)
			{
				myCanvasGroup.alpha = 1;
				myCanvasGroup.interactable = true;
				fadeIn = false;
			}
		}
		if (fadeOut) 
		{
			myCanvasGroup = canvasGameObj.GetComponent<CanvasGroup> ();
			myCanvasGroup.alpha = myCanvasGroup.alpha - Time.deltaTime * 4f;
			myCanvasGroup.interactable = true;
			if (myCanvasGroup.alpha <= 0) 
			{
				myCanvasGroup.alpha = 0;
				myCanvasGroup.interactable = false;
				fadeOut = false;
			}
		}
	}

	public void toggleCreateCanvas(GameObject canvas)
	{
		if(SelectPlayer.currentPlayer == "")
		{
			StartCoroutine("canvasToggle", canvas);
			canvasGameObj = canvas;
		}
		else
		{
			StartCoroutine("loadBakeshop");
			PlayBGM.fadeOut = true;
			FadeScene.fadeOut();
		}
		clickSound.Play ();
	}

	IEnumerator canvasToggle(GameObject canvas)
	{
		yield return new WaitForSeconds(0.3f);
		if (canvas.activeSelf) {
			fadeOut = true;
			canvas.SetActive (false);
		} else if (!canvas.activeSelf) {
			canvas.GetComponent<CanvasGroup>().alpha = 0;
			fadeIn = true;
			canvas.SetActive (true);
		}
	}

	IEnumerator loadBakeshop()
	{
		yield return new WaitForSeconds(0.5f);
		Application.LoadLevel("Bakeshop");
	}
}
