using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	float money = 0;
	Text moneyText;
	GameObject behave;
	
	// Use this for initialization
	void Start () {

		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		moneyText = GetComponent<Text> ();
		money = behave.GetComponent<GameBehaviour> ().money;
	}
	
	// Update is called once per frame
	void Update () {
		money = behave.GetComponent<GameBehaviour> ().money;
		moneyText.text = money.ToString();
	}
	

}
