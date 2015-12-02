using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Resize1024by600 : MonoBehaviour 
{
	private float cScaleX;
	private float cScaleY;
	void Start()
	{
		resize ();
	}
	private void resize()
	{
		float width=Camera.main.orthographicSize * 1f * Screen.width / Screen.height;
		transform.localScale = new Vector3(width / 512f, width / 512f, 1f);
		cScaleX = transform.localScale.x;
		cScaleY = transform.localScale.y;
		Debug.Log("Tutorial Resized!");
	}
}