using UnityEngine;
using System.Collections;

public class Outside : MonoBehaviour {

	public string[] dialogs;
	public string[] names;

	public Outside(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[12];
		sDialog = new string[12];
		
		sName[0] = "Prologue";
		sName[1] = "Felicia";
		sName[2] = namePlayer;
		sName[3] = "Felicia";
		sName[4] = namePlayer;
		sName[5] = "Felicia";
		sName[6] = namePlayer;
		sName[7] = "Felicia";
		sName[8] = namePlayer;
		sName[9] = "Felicia";
		sName[10] = namePlayer;
		sName[11] = "Felicia";
		
		// Story Premise
		sDialog[0] = "Felicia Galeo just graduated from college, and as a graduation gift," +
			"her dad gave her a rundown place to restore and use as her first bakeshop.";
		// Player
		sDialog[1] = "215 M. Blanc Street, Parisse... I guess this is the place. My dad mentioned " +
			"that someone would meet me outside, but I wonder where that person could be.";
		sDialog[2] = "Umm, excuse me?.. But I was looking for someone named Felicia. By any chance--";
		// Felicia
		sDialog[3] = "Finally! I was looking for you all over the place! Oh... sorry, I forgot my " +
			"manners. I’m Felicia Galeo, and you are?";
		// Player
		sDialog[4] = "My name is "+namePlayer+". It’s nice to finally meet you.";
		// Felicia
		sDialog[5] = "The pleasure is mine.";
		// Player
		sDialog[6] = "So I heard you just graduated from college, and you’re planning to start your " +
			"first bakeshop? Congratulations by the way.";

		// Felicia
		sDialog [7] = "Thanks. Yes, that’s right. I’ve always wanted to build my own bakeshop. " +
			"Once we start, I’d like to call the main branch ‘Pan de Felicia’.";

		sDialog[8] = "Sounds great.";

		sDialog[9] = "Anyway, I suppose my dad already informed you about today’s work?";
		// Player
		sDialog[10] = "Actually, not very much... He was rushing over the phone when we discussed the job " +
			"offer so I am not really sure about the exact details.";
		// Felicia
		sDialog[11] = "Well, that really sounds like my dad. He is always busy, you know. Anyway, don’t worry. " +
			"I will fill in the details later. Why don’t we come in first?";

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
