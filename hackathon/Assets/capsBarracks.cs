using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class capsBarracks : MonoBehaviour {

	int caps = 0;
	Text capsText;
	GameObject behave;
	
	// Use this for initialization
	void Start () {
		
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		capsText = GetComponent<Text> ();
		caps = behave.GetComponent<UpgradeScreen> ().caps;
	}
	
	// Update is called once per frame
	void Update () {
		caps = behave.GetComponent<UpgradeScreen> ().caps;
		capsText.text = caps.ToString();
	}
}
