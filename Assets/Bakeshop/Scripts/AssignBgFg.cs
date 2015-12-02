using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AssignBgFg : MonoBehaviour {

	public GameObject bgImage;
	public GameObject fgImage;

	// Use this for initialization
	void Start () {
		
		Image bgSprite = bgImage.GetComponent<Image>();
		bgSprite.sprite = (Sprite)Resources.Load(Application.loadedLevelName+"/bg", typeof(Sprite));

		Image fgSprite = fgImage.GetComponent<Image>();
		fgSprite.sprite = (Sprite)Resources.Load(Application.loadedLevelName+"/fg", typeof(Sprite));
	}
}
