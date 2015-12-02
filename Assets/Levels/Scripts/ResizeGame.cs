using UnityEngine;
using System.Collections;

public class ResizeGame : MonoBehaviour {
	public static float tScaleX;
	public static float tScaleY;

	void Start()
	{
		float width=Camera.main.orthographicSize * 2.0f * Screen.width / Screen.height;
		transform.localScale = new Vector3(width / 17.05f, width / 17.05f, 1f);
		
		tScaleX = transform.localScale.x;
		tScaleY = transform.localScale.y;
		
		Debug.Log("Resized!");
	}

}
