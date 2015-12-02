using UnityEngine;
using System.Collections;

public class Bakeshop4 : MonoBehaviour {

	public string[] dialogs;
	public string[] names;
	
	public Bakeshop4(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[9];
		sDialog = new string[9];
		
		sName[0] = "Felicia";
		sDialog [0] = "Hey, that’s the last item we need! I was so busy and having so much fun ";
		
		sName[1] = "Felicia";
		sDialog[1] = "That I didn’t notice we’re done finding the special items for this branch.";
		
		sName[2] = namePlayer;
		sDialog [2] = "I can’t believe it myself. It has been that long, and now you can open your second bakeshop!";
		
		sName[3] = "Felicia";
		sDialog[3] = "Teehee, it’s all thanks to you. Actually, I received a message from my father saying...";
		
		sName[4] = "Felicia";
		sDialog [4] = "that he found another place in Dublanc that I can use if ever... You know, if I decided to expand my bakeshop.";
		
		sName [5] = namePlayer;
		sDialog [5] = "Awesome!";
		
		sName[6] = "Felicia";
		sDialog [6] = "Time to get our hands dirty and give this new branch an upgrade! Let's continue doing flash sales to earn more cash,";
		
		sName[7] = "Felicia";
		sDialog[7] = "I heard it get's more difficult as objects to find become more obscured. I'm sure customers will pay extra bucks in exchange for some fun.";

		sName[8] = "System";
		sDialog[8] = "Congratulations for completing your bakeshop! You have earned $13,000 cash bonus which you can use for purchasing the new branch.";
		
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
