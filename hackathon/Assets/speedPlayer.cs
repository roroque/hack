using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class speedPlayer : MonoBehaviour {

	float atribute = 0;
	Text TextAt;
	GameObject behave;
	
	// Use this for initialization
	void Start () {
		
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		TextAt = GetComponent<Text> ();
		atribute = behave.GetComponent<UpgradeScreen> ().playerAtackSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		atribute = behave.GetComponent<UpgradeScreen> ().playerAtackSpeed;
		//print (atribute.ToString ());
		TextAt.text = atribute.ToString();
	}
}
