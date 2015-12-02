/// <summary>
/// HintLoad.cs
/// Handle Animator component
/// Controlling the speed of animation based on game modes because each game modes has different hint cooldowns
/// </summary>
using UnityEngine;
using System.Collections;

public class HintLoad : MonoBehaviour {
	Animator hintAnimator;

	// Use this for initialization
	void Start () {
		hintAnimator = GetComponent<Animator>();

		if(LevelManager.gameMode == "easy")
			hintAnimator.speed = 2f;
		else if(LevelManager.gameMode == "medium")
			hintAnimator.speed = 40f / 30f;
		else if(LevelManager.gameMode == "hard")
			hintAnimator.speed = 1f;
	}
	
}
