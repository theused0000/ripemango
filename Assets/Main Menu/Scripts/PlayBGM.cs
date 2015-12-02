using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayBGM : MonoBehaviour {
	public static AudioSource gameMenu;
	public static AudioSource clickSound;
	public static AudioSource foundSound;
	public static AudioSource hintSound;
	public static AudioSource coinSound;
	private float vol;
	private bool fadeIn;
	public static bool fadeOut;
	public static bool musicToggle = true;
	public Toggle soundToggleObj;
	// Use this for initialization
	void Awake() {
		gameMenu = this.GetComponent<AudioSource> ();
	}
	void Start () {
		Debug.Log (musicToggle);
		gameMenu.volume = 0;
		clickSound = GameObject.Find ("clickSound").GetComponent<AudioSource> ();

		if (GameObject.Find ("hintSound") != null) {
			foundSound = GameObject.Find ("foundSound").GetComponent<AudioSource> ();
			hintSound = GameObject.Find ("hintSound").GetComponent<AudioSource> ();
			coinSound = GameObject.Find ("coinSound").GetComponent<AudioSource> ();
		}

		if (!musicToggle) {
			soundToggleObj.isOn = false;
			gameMenu.enabled = false;
			clickSound.enabled = false;
			musicToggle = false;
			if(GameObject.Find ("hintSound") != null) {
				foundSound.enabled = false;
				hintSound.enabled = false;
				coinSound.enabled = false;
			}
		} else {
			soundToggleObj.isOn = true;
			gameMenu.enabled = true;
			clickSound.enabled = true;
			gameMenu.Play();
			fadeOut = false;
			fadeIn = true;
			if(GameObject.Find ("hintSound") != null) {
				foundSound.enabled = true;
				hintSound.enabled = true;
				coinSound.enabled = true;
			}
		}

	}
	void Update()
	{
		if (fadeIn)
		{
			vol += 0.1f * Time.deltaTime * 10f;
			if (vol >= 1)
			{
				vol = 1;
				fadeIn = false;
			}
		}
		else if(fadeOut)
		{
			vol -= 0.1f * Time.deltaTime * 20f;
			if (vol <= 0)
			{
				vol = 0;
				fadeOut = false;
			}
		}
		gameMenu.volume = vol;
	}
	public void turnOffBGM()
	{
		if (gameMenu.enabled && musicToggle) {
			gameMenu.enabled = false;
			clickSound.enabled = false;
			musicToggle = false;
			if(GameObject.Find ("hintSound") != null) {
				foundSound.enabled = false;
				hintSound.enabled = false;
				coinSound.enabled = false;
			}
		}
		else {
			gameMenu.enabled = true;
			clickSound.enabled = true;
			gameMenu.Play();
			fadeIn = true;
			musicToggle = true;
			if(GameObject.Find ("hintSound") != null) {
				foundSound.enabled = true;
				hintSound.enabled = true;
				coinSound.enabled = true;
			}
		}
	}
}
