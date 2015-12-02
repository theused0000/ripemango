using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {

	public string[] dialogs;
	public string[] names;
	
	public GameEnd(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[11];
		sDialog = new string[11];
		
		sName[0] = "Felicia";
		sDialog [0] = "Wow! This is our fifth bakeshop! I can’t imagine we’ve come such a long way.";

		sName[1] = namePlayer;
		sDialog[1] = "I’m so proud of you, Felicia.";
		
		sName[2] = "Felicia";
		sDialog[2] = "Ditto. I guess we should focus on managing all the branches from now on. Having five bakeshops to manage will surely be tough.";
		
		sName[3] = namePlayer;
		sDialog [3] = "Yes, you should. But don’t worry, I know you can do it.";
		
		sName[4] = "Felicia";
		sDialog[4] = "What do you mean?";
		
		sName[5] = namePlayer;
		sDialog[5] = "Well, I’m thinking this is the proper time to say goodbye?";
		
		sName[6] = namePlayer;
		sDialog[6] = "Now that you have accomplished everything, it’s time for us to go our separate ways.";
		
		sName[7] = "Felicia";
		sDialog [7] = "You know you’ve been a great help to me, "+namePlayer+". Thank you for everything you’ve done. I will surely miss you.";
		
		sName[8] = namePlayer;
		sDialog[8] = "Hey, no crying. We will see each other again, right? So don’t be sad. I wish you good luck, Felicia.";
		
		sName[9] = "Felicia";
		sDialog[9] = "Thank you.";
		
		sName[10] = "System";
		sDialog[10] = "Congratulations for completing the game! Thank you for playing!";
		
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
