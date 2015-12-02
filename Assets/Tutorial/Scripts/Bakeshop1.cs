using UnityEngine;
using System.Collections;

public class Bakeshop1 : MonoBehaviour {

	public string[] dialogs;
	public string[] names;
	
	public Bakeshop1(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[17];
		sDialog = new string[17];
		
		sName[0] = "Felicia";
		sDialog [0] = "Wow, look at this place. It is huge!";

		sName[1] = namePlayer;
		sDialog [1] = "Is this the first time you visited this place?";

		sName[2] = "Felicia";
		sDialog [2] = "Actually, my dad only told me about this yesterday. You know, he loves surprises. ";

		sName [3] = "Felicia";
		sDialog[3] = "He said this is his graduation gift for me, and to make up for being away most of the time.";

		sName[4] = namePlayer;
		sDialog[4] = "So he really is a busy person.";

		sName[5] = "Felicia";
		sDialog[5] = "Beats me. Anyway, this place was owned by another baker. Dad said the previous owner had to move out of town...";

		sName[6] = "Felicia";
		sDialog[6] = "because he was offered an excellent job and immediately sold the place. He did not even bother to take most of his things.";

		sName[7] = namePlayer;
		sDialog [7] = "That must really be an excellent job to leave his stuff, right?";

		sName[8] = "Felicia";
		sDialog [8] = "I guess. But that’s good news for us. To be honest, I’m totally broke right now. And I think some of the";
		
		sName[9] = "Felicia";
		sDialog[9] = "equipment here are not in good condition anymore, especially the kitchen. It needs extra work.";

		sName[10] = namePlayer;
		sDialog [10] = "Then how is that good news?";

		sName[11] = "Felicia";
		sDialog[11] = "If we are going to restore this place, then we will need money.";

		sName[12] = "Felicia";
		sDialog[12] = "And since the previous owner abandoned most of his things,...";

		sName [13] = "Felicia";
		sDialog [13] = "I guess it wouldn’t hurt if we clean up and... You know, hold a flash sale to make bucks.";

		sName [14] = namePlayer;
		sDialog [14] = "That’s a rather nice idea.";

		sName [15] = "Felicia";
		sDialog [15] = "And while we’re at it, let’s also find some baking stuff that might actually be useful.";

		sName [16] = "Felicia";
		sDialog [16] = "I think there are still some good items left. Come on, let’s check it out.";
		
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
