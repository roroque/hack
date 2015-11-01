using UnityEngine;
using System.Collections;

public class UpgradeWeaponScreen : MonoBehaviour {

	public float money;
	public int caps;

	// Use this for initialization
	void Start () {
		money = PlayerPrefs.GetFloat ("money", 0.0F);
		caps = PlayerPrefs.GetInt ("caps", 0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToCBarracks(){
		
		Application.LoadLevel("barracks");
		
	}

	public void setWeapon(int weaponCode){

		switch (weaponCode) {
		case 1:
			PlayerPrefs.SetString ("equipped", "weapon1");
			break;
		case 2:
			PlayerPrefs.SetString ("equipped", "weapon2");
			break;
		case 3:
			PlayerPrefs.SetString ("equipped", "weapon3");
			break;

		default: 
			print ("codigo de arma invalido");
			break;
		}

	}
}
