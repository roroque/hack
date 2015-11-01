using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moneyBarracks : MonoBehaviour {

	float money = 0;
	Text moneyText;
	GameObject behave;
	
	// Use this for initialization
	void Start () {
		
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		moneyText = GetComponent<Text> ();
		money = behave.GetComponent<UpgradeScreen> ().money;
	}
	
	// Update is called once per frame
	void Update () {
		money = behave.GetComponent<UpgradeScreen> ().money;
		moneyText.text = money.ToString();
	}
	

}
