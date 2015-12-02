using UnityEngine;
using System.Collections;

public class UnlockFurns : MonoBehaviour {

	public static void disableFurns () {
		if(LevelManager.currentLevel < 6) {
			FurnShop.f.interactable = false;
			FurnShop.wd.interactable = false;
			FurnShop.ld.interactable = false;
			FurnShop.p.interactable = false;
			FurnShop.fl.interactable = false;
			FurnShop.dw.interactable = false;
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 5 && LevelManager.currentLevel < 12 ) {
			FurnShop.wd.interactable = false;
			FurnShop.ld.interactable = false;
			FurnShop.p.interactable = false;
			FurnShop.fl.interactable = false;
			FurnShop.dw.interactable = false;
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 11 && LevelManager.currentLevel < 16 ) {
			FurnShop.ld.interactable = false;
			FurnShop.p.interactable = false;
			FurnShop.fl.interactable = false;
			FurnShop.dw.interactable = false;
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 15 && LevelManager.currentLevel < 20) {
			FurnShop.p.interactable = false;
			FurnShop.fl.interactable = false;
			FurnShop.dw.interactable = false;
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 19 && LevelManager.currentLevel < 25) {
			FurnShop.fl.interactable = false;
			FurnShop.dw.interactable = false;
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 24 && LevelManager.currentLevel < 35) {
			FurnShop.dw.interactable = false;
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 34 && LevelManager.currentLevel < 42) {
			FurnShop.st.interactable = false;
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 41 && LevelManager.currentLevel < 50) {
			FurnShop.ft.interactable = false;
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 49 && LevelManager.currentLevel < 58) {
			FurnShop.kt.interactable = false;
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 57 && LevelManager.currentLevel < 67) {
			FurnShop.sh.interactable = false;
			FurnShop.gr.interactable = false;
		} else 
		if(LevelManager.currentLevel > 66 && LevelManager.currentLevel < 70) {
			FurnShop.gr.interactable = false;
		}
	}
}
