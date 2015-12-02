using UnityEngine;
using System.Collections;

public class LoadMainMenu : MonoBehaviour {
	public static GameObject fadeOutObj;
	
	void Start()
	{
		StartCoroutine ("tweenLogo");
	}
	
	IEnumerator tweenLogo() {
		yield return new WaitForSeconds(5f);
		Application.LoadLevel ("Main Menu");
	}
}
