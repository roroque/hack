using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class weaponBarracks : MonoBehaviour {

	GameObject weapon;
	Image weaponImage;
	GameObject behave;
	
	// Use this for initialization
	void Start () {
		
		behave = GameObject.FindGameObjectWithTag ("Behaviour");
		weaponImage = GetComponent<Image> ();


	}
	
	// Update is called once per frame
	void Update () {
		weapon = behave.GetComponent<UpgradeScreen> ().selected;
		weaponImage.sprite = weapon.GetComponent<SpriteRenderer>().sprite;
	}

}
