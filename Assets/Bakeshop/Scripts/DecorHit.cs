/// <summary>
/// Decor hit.cs
/// When a decorative item is clicked, it sets the trivia pop-up on game scene
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DecorHit : MonoBehaviour 
{
	public static string currentDecor = "";
	// When a decorative item is clicked in Bakeshop scene
	private int newShop = 1;
	public void hit()
	{
		currentDecor = this.gameObject.name;
		DecorsDb.setTrivia();
		Debug.Log(currentDecor);
	}
	// When a decorative item is clicked in Game Level scene
	public void hitLevel()
	{
		if (LevelManager.currentLevel > 60 && LevelManager.currentLevel < 121) {
			newShop = 2;
		} else if (LevelManager.currentLevel > 120 && LevelManager.currentLevel < 181) {
			newShop = 3;
		} else if (LevelManager.currentLevel > 180 && LevelManager.currentLevel < 241) {
			newShop = 4;
		} else if (LevelManager.currentLevel > 240) {
			newShop = 5;
		}


		if(ObjectPressed.objectPressed && ObjectPressed.objectPressedName2 == this.gameObject.name)
		{
			currentDecor = this.gameObject.name;
			DecorsDb.setTrivia();

			if(LevelManager.playMode == "story")
				PlayerPrefs.SetInt(currentDecor+""+GameManager.num+newShop, 1);
		}
	}
}
