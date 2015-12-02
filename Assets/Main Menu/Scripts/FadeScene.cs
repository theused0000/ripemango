using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeScene : MonoBehaviour {
	public static GameObject fadeOutObj;

	void Start()
	{
		GameObject fadeInObj = GameObject.Find ("FadeIn");
		fadeOutObj = GameObject.Find ("FadeOut");
		fadeOutObj.SetActive (false);
		StartCoroutine ("fadeIn", fadeInObj);
	}

	IEnumerator fadeIn(GameObject fiObj)
	{
		yield return new WaitForSeconds(1f);
		fiObj.SetActive (false);
	}

	public void fadeScene()
	{
		fadeOutObj.SetActive (true);
	}

	public static void fadeOut()
	{
		fadeOutObj.SetActive (true);
	}
}
