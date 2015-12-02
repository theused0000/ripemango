using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class ResizeCanvas : MonoBehaviour 
{
	public static float cScaleX;
	public static float cScaleY;
	void Start()
	{
		resize ();
	}
	private void resize()
	{
		float width=Camera.main.orthographicSize * 1f * Screen.width / Screen.height;
		transform.localScale = new Vector3(width / 400f, width / 400f, 1f);
		cScaleX = transform.localScale.x;
		cScaleY = transform.localScale.y;
		Debug.Log("Resized!");
	}
}
