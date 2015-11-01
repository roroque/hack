using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class wepSpeedBarrack : MonoBehaviour {
	GameObject weapon;
	Text TextAt;
	GameObject behave;

	// Use this for initialization
	void Start () {
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		TextAt = GetComponent<Text> ();


	
	}
	
	// Update is called once per frame
	void Update () {
		weapon = GameObject.FindGameObjectWithTag("Weapon");

		TextAt.text = weapon.GetComponent<WeaponSystem> ().getAtackSpeedLvl ().ToString();

	
	}
}
