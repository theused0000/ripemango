using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	public string[] dialogs;
	public string[] names;
	
	public Level1(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[9];
		sDialog = new string[9];
		
		sName[0] = "Felicia";
		sDialog [0] = "Before we start, I would like to give some quick notes about Flash Sale.";
		
		sName[1] = "Felicia";
		sDialog [1] = "I will be mentioning a list of stuff that can be sold in the flash sale. ";

		sName[2] = "Felcia";
		sDialog[2] = "It can be a list of pictures, words, or silhouettes of the items you need to find.";
		
		sName[3] = "Felicia";
		sDialog[3] = "You will need to tap an item to make a sale and collect the coin from buyers.";
		
		sName[4] = "Felicia";
		sDialog[4] = "If we find items consecutively within 5 seconds, the customers will give us bonus coins and score depending on how fast we move.";
		
		sName[5] = "Felicia";
		sDialog[5] = "And one more thing. In case you get stuck, you can also use a Hint.";

		sName[6] = "Felicia";
		sDialog[6] = "You can also pinch the screen to get a larger view of the area. This way you can find items a lot easier.";
		
		sName[7] = "Felicia";
		sDialog [7] = "As I mentioned before, we might be able to find some pretty cool stuff here for the bakeshop. ";

		sName[8] = "Felicia";
		sDialog[8] = "Let's call those 'special items'. Easy right? Let's get started then!";
		
		dialogs = sDialog;
		names = sName;
	}
	
	public string[] getDialogs() {
		return dialogs;
	}
	
	public string[] getNames() {
		return names;
	}
}
