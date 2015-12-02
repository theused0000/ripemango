using UnityEngine;
using System.Collections;

public class Bakeshop3 : MonoBehaviour {

	public string[] dialogs;
	public string[] names;
	
	public Bakeshop3(string[] sName, string[] sDialog, string namePlayer) {
		sName = new string[16];
		sDialog = new string[16];
		
		sName[0] = "Felicia";
		sDialog [0] = "Hey, that’s the last item we need! I was so busy and having so much fun that ";

		sName[1] = "Felicia";
		sDialog[1] = "I didn’t notice we’re done finding the special items.";
		
		sName[2] = namePlayer;
		sDialog [2] = "I can’t believe it myself. It has been that long, and now you can finally open your first bakeshop!";

		/*sName[3] = "Felicia";
		sDialog[3] = "Teehee, it’s all thanks to you. And actually about the name, I have something in my mind since we started working.";

		sName[4] = namePlayer;
		sDialog[4] = "And what is that?";
		
		sName[5] = "Felicia";
		sDialog[5] = "I’d like to call the bakeshop ‘Pan de Felicia.’ What do you think?";
		
		sName[6] = namePlayer;
		sDialog [6] = "Sounds great!";*/

		sName[3] = "Felicia";
		sDialog[3] = "Teehee, it’s all thanks to you. And actually about opening the bakeshop, I received a message from my father saying...";

		sName[4] = "Felicia";
		sDialog [4] = "that he found another place in Jehanna that I can use if ever... You know, if I decided to expand my bakeshop.";

		sName [5] = namePlayer;
		sDialog [5] = "Really? I didn’t know your family is that rich?";

		sName[6] = "Felicia";
		sDialog [6] = "Well, it’s all because of hard work. And my dad taught us to work on our own...";

		sName[7] = "Felicia";
		sDialog[7] = "...we want to achieve our dreams without relying too much on others.";

		sName[8] = namePlayer;
		sDialog[8] = "That makes sense.";

		sName[9] = "Felicia";
		sDialog[9] = "But don’t get the wrong idea, he’s not giving it for free. I will have to work harder if I want to have an expansion.";

		sName[10] = "Felicia";
		sDialog[10] = "So I’m planning to visit the place and decide if I will take it. If it’s not too much, I’d like to ask for your help again if ever—";

		sName[11] = namePlayer;
		sDialog[11] = "You don’t need to ask, it’s always my pleasure. Besides, we make a good tandem right?";

		sName[12] = "Felicia";
		sDialog[12] = "Great, thanks! Let’s keep this bakeshop together and work on our expansion!";

		sName[13] = "System";
		sDialog[13] = "Congratulations for completing your first bakeshop! From this point forward, you can work on ";

		sName[14] = "System";
		sDialog[14] = "expanding your business by opening branches on different places! ";

		sName[15] = "System";
		sDialog[15] = "As a reward for completing the bakeshop, you have receive $12,000 cash bonus to purchase the next area. " +
			"Renovate new areas and turn it into another successful bakeshop!";

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
