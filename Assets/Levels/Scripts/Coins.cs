using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Coins : MonoBehaviour 
{
	private AudioSource coinSound;
	private GameObject moneyBonus1, moneyBonus2, moneyBonus3, moneyBonus4;

	void Start()
	{
		coinSound = GameObject.Find ("coinSound").GetComponent<AudioSource>();
	}
	public void coinHit()
	{

		coinSound.Play ();
		GameStart.objNum++;

		if(ObjectPressed.coins1 != null)
		{
			if (this.gameObject.name == ObjectPressed.coins1.name)
			{
				if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
					GameStart.clueObject[0].SetActive(true);
				else if(GameStart.rdmMode == 3)
					GameStart.wordArray[0].SetActive(true);
				SelectPlayer.money += ObjectPressed.currentCoin[0];
				moneyBonus1 = (GameObject)Instantiate (Resources.Load ("Levels/moneyBonus"), ObjectPressed.coins1.transform.position, ObjectPressed.coins1.transform.rotation);
				moneyBonus1.transform.SetParent(GameObject.Find("Game Objects").transform);
				moneyBonus1.transform.localScale = new Vector3(1,1,1);
				moneyBonus1.GetComponent<Text>().text = "+$"+ObjectPressed.currentCoin[0];
				Destroy(moneyBonus1, 2f);
				Destroy(ObjectPressed.coins1);
				GameStart.clueIndex1++;
			}
		}
		if(ObjectPressed.coins2 != null)
		{
			if(this.gameObject.name == ObjectPressed.coins2.name)
			{
				if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
					GameStart.clueObject[1].SetActive(true);
				else if(GameStart.rdmMode == 3)
					GameStart.wordArray[1].SetActive(true);
				SelectPlayer.money += ObjectPressed.currentCoin[1];
				moneyBonus2 = (GameObject)Instantiate (Resources.Load ("Levels/moneyBonus"), ObjectPressed.coins2.transform.position, ObjectPressed.coins2.transform.rotation);
				moneyBonus2.transform.SetParent(GameObject.Find("Game Objects").transform);
				moneyBonus2.transform.localScale = new Vector3(1,1,1);
				moneyBonus2.GetComponent<Text>().text = "+$"+ObjectPressed.currentCoin[1];
				Destroy(moneyBonus2, 2f);
				Destroy(ObjectPressed.coins2);
				GameStart.clueIndex2++;
			}
		}
		if(ObjectPressed.coins3 != null)
		{
			if(this.gameObject.name == ObjectPressed.coins3.name)
			{
				if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
					GameStart.clueObject[2].SetActive(true);
				else if(GameStart.rdmMode == 3)
					GameStart.wordArray[2].SetActive(true);
				SelectPlayer.money += ObjectPressed.currentCoin[2];
				moneyBonus3 = (GameObject)Instantiate (Resources.Load ("Levels/moneyBonus"), ObjectPressed.coins3.transform.position, ObjectPressed.coins3.transform.rotation);
				moneyBonus3.transform.SetParent(GameObject.Find("Game Objects").transform);
				moneyBonus3.transform.localScale = new Vector3(1,1,1);
				moneyBonus3.GetComponent<Text>().text = "+$"+ObjectPressed.currentCoin[2];
				Destroy(moneyBonus3, 2f);
				Destroy(ObjectPressed.coins3);
				GameStart.clueIndex3++;
			}
		}
		if(ObjectPressed.coins4 != null)
		{
			if(this.gameObject.name == ObjectPressed.coins4.name)
			{
				if(GameStart.rdmMode == 1 || GameStart.rdmMode == 2)
					GameStart.clueObject[3].SetActive(true);
				else if(GameStart.rdmMode == 3)
					GameStart.wordArray[3].SetActive(true);
				SelectPlayer.money += ObjectPressed.currentCoin[3];
				moneyBonus4 = (GameObject)Instantiate (Resources.Load ("Levels/moneyBonus"), ObjectPressed.coins4.transform.position, ObjectPressed.coins4.transform.rotation);
				moneyBonus4.transform.SetParent(GameObject.Find("Game Objects").transform);
				moneyBonus4.transform.localScale = new Vector3(1,1,1);
				moneyBonus4.GetComponent<Text>().text = "+$"+ObjectPressed.currentCoin[3];
				Destroy(moneyBonus4, 2f);
				Destroy(ObjectPressed.coins4);
				GameStart.clueIndex4++;
			}
		}
		UpdateDbase.updateMoney();
	}
}