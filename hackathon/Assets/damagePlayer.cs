using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class damagePlayer : MonoBehaviour {

	float atribute = 0;
	Text TextAt;
	GameObject behave;
	
	// Use this for initialization
	void Start () {
		
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		TextAt = GetComponent<Text> ();
		atribute = behave.GetComponent<UpgradeScreen> ().playerDamage;
	}
	
	// Update is called once per frame
	void Update () {
		atribute = behave.GetComponent<UpgradeScreen> ().playerDamage;
		TextAt.text = atribute.ToString();
	}
}
