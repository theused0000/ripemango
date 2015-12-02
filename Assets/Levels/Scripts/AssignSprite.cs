using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AssignSprite : MonoBehaviour {

	public static GameObject bgImage;
	public static GameObject fgImage;

	// Use this for initialization
	public static void setBgFg () {
		bgImage = GameObject.Find ("Background");
		fgImage = GameObject.Find ("Foreground");

		Image bgSprite = bgImage.GetComponent<Image>();
		bgSprite.sprite = (Sprite)Resources.Load("LevelSprites/"+LevelSpawn.newLevel+"/bg", typeof(Sprite));
		Image fgSprite = fgImage.GetComponent<Image>();
		fgSprite.sprite = (Sprite)Resources.Load("LevelSprites/"+LevelSpawn.newLevel+"/fg", typeof(Sprite));
	}
}
