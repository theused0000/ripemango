using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class DisableCanvas : MonoBehaviour
{
	private CanvasGroup designBtn;
	private int setCount = 0;

	void Start() {
		designBtn = GameObject.Find("DesignButton").GetComponent<CanvasGroup>();
	}
	public void toggleDecors() 
	{
		GameObject bakeshop = GameObject.Find ("Canvas");
		RectTransform bakeshopScale = bakeshop.GetComponent<RectTransform>();
		CanvasGroup decors = bakeshop.GetComponent<CanvasGroup>();
		if(decors.interactable)
		{
			decors.interactable = false;
			/*bakeshopScale.localPosition = new Vector3(0f, 45f);
			bakeshopScale.localScale = new Vector3(ResizeCanvas.cScaleX - 0.2f, ResizeCanvas.cScaleY - 0.2f);*/
		}
		else
		{
			decors.interactable = true;
			/*bakeshopScale.localPosition = new Vector3(0f, 0f);
			bakeshopScale.localScale = new Vector3(ResizeCanvas.cScaleX, ResizeCanvas.cScaleY);*/
		}
	}

	public void toggleRightSet() {
		if (setCount < 2) {
			setCount++;
		}
		if (setCount == 1) {
			enableSet (FurnShop.set [1]);
			disableSet (FurnShop.set [0], FurnShop.set [2]);
		} else if (setCount == 2) {
			enableSet (FurnShop.set [2]);
			disableSet (FurnShop.set [0], FurnShop.set [1]);
		} else if (setCount == 0) {
			enableSet (FurnShop.set [0]);
			disableSet (FurnShop.set [1], FurnShop.set [2]);
		}
		Debug.Log ("Set count: "+setCount);
	}

	public void toggleLeftSet() {
		if (setCount > 0) {
			setCount--;
		}
		if (setCount == 1) {
			enableSet (FurnShop.set [1]);
			disableSet (FurnShop.set [0], FurnShop.set [2]);
		} else if (setCount == 2) {
			enableSet (FurnShop.set [2]);
			disableSet (FurnShop.set [0], FurnShop.set [1]);
		} else if (setCount == 0) {
			enableSet (FurnShop.set [0]);
			disableSet (FurnShop.set [1], FurnShop.set [2]);
		}
		Debug.Log ("Set count: "+setCount);
	}

	public void enableSet(CanvasGroup cg) {
		cg.interactable = true;
		cg.alpha = 1;
		cg.blocksRaycasts = true;
	}

	public void disableSet(CanvasGroup cg1, CanvasGroup cg2) {
		cg1.interactable = false;
		cg1.alpha = 0;
		cg1.blocksRaycasts = false;
		cg2.interactable = false;
		cg2.alpha = 0;
		cg2.blocksRaycasts = false;
	}
	
	public void toggleDesign() {
		if(designBtn.interactable)
		{
			designBtn.interactable = false;
			designBtn.alpha = 0;
			designBtn.blocksRaycasts = false;
		}
		else
		{
			designBtn.interactable = true;
			designBtn.alpha = 1;
			designBtn.blocksRaycasts = true;
		}
	}
}
