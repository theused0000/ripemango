/// <summary>
/// ResizeBg.cs
/// Resize Background image to fit to any screen resolution
/// </summary>
using UnityEngine;
using System.Collections;

public class ResizeBg : MonoBehaviour {

	void Start()
	{
		SpriteRenderer sr=GetComponent<SpriteRenderer>();
		if(sr==null) return;
		
		float worldScreenHeight=Camera.main.orthographicSize*2f;
		float worldScreenWidth=worldScreenHeight/Screen.height*Screen.width;
		
		transform.localScale = new Vector3(
			worldScreenWidth / sr.sprite.bounds.size.x,
			worldScreenHeight / sr.sprite.bounds.size.y, 1);

	}
}
