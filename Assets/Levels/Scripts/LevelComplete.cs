using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelComplete : MonoBehaviour {
	public GameObject popUp;
	public Text popUpTxt;

	void OnEnable() {
		popUp.SetActive (true);
		popUpTxt.text = "Congratulations, you have completed all the levels from the Story Mode. Keep playing on the Arcade Mode to earn more cash to continue working on our bakeshop branches!";
	}
}
