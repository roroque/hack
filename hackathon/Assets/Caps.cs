using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Caps : MonoBehaviour {

	float caps = 0;
	Text capsText;
	GameObject behave;
	
	// Use this for initialization
	void Start () {
		
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		capsText = GetComponent<Text> ();
		caps = behave.GetComponent<GameBehaviour> ().caps;
	}
	
	// Update is called once per frame
	void Update () {
		caps = behave.GetComponent<GameBehaviour> ().caps;
		capsText.text = caps.ToString();
	}
	


}
