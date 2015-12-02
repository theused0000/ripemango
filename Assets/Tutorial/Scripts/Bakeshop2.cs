using UnityEngine;
using System.Collections;

public class Bakeshop2 : MonoBehaviour {

	public string[] dialogs;
	public string[] names;
	
	public Bakeshop2(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[9];
		sDialog = new string[9];
		
		sName[0] = "Felicia";
		sDialog [0] = "I think we found the first special item.";
		
		sName[1] = "Felicia";
		sDialog [1] = "You can check the details of the special items we found in the bakeshop.";

		sName[2] = "Felicia";
		sDialog[2] = "You just have to tap on the item to read the info.";
		
		sName[3] = "Felicia";
		sDialog[3] = "Now that we also earned some cash, let’s check out the store and see if we can afford some new equipment.";
		
		sName[4] = "Felicia";
		sDialog [4] = "Looks like some items are not yet available for purchase. Maybe we can come back later once it opens up.";

		sName[5] = "Felicia";
		sDialog[5] = "For now let’s check their current stock.";
		
		sName[6] = "Felicia";
		sDialog[6] = "There are quite a bit of items for sale. But remember to stick on our budget upon buying stuff. There is a lot of stuff we need to buy.";
		
		sName[7] = "Felicia";
		sDialog[7] = "Lovely! Now you know the drill: earn cash, find special items and buy decorative items for the bakeshop.";

		sName[8] = "Felicia";
		sDialog[8] = "Let’s earn some more and start improving the kitchen.";
		
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
