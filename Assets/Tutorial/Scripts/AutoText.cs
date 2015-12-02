using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AutoText : MonoBehaviour {
	static IEnumerator SetText;

	public static void TypeText(Text textElement, string text, float time){
		TutorialManager.typing = true;
		float characterDelay = time / text.Length;
		SetText = typeWriter(textElement, text, characterDelay);
		textElement.StartCoroutine(SetText);
	}

	static IEnumerator typeWriter(Text textElement, string text, float characterDelay){
		for(int i=0; i<text.Length; i++){
			textElement.text += text[i];
			yield return new WaitForSeconds(characterDelay);
			if(i == text.Length-1)
				TutorialManager.typing = false;
		}
	}

	public static void stopTypeWriter(Text textElement) {
		textElement.StopCoroutine (SetText);
	}
}