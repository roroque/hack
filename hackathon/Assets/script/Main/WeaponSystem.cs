using UnityEngine;
using System.Collections;

public class WeaponSystem : MonoBehaviour {

	public string weaponName = "gun";

	public float damage;
	private int damageLvl;
	public float atackSpeed;
	private int atackSpeedLvl; 
	public float critChance;
	private int critChanceLvl;
	public GameObject projectile;

	private GameObject enemy;

	// Use this for initialization
	void Start () {

		damageLvl = PlayerPrefs.GetInt((weaponName + "dmg"));
		atackSpeedLvl = PlayerPrefs.GetInt((weaponName + "speed"));
		critChanceLvl = PlayerPrefs.GetInt((weaponName + "crit"));


		//define the lvl and attribute relationship
		damage = damage * damageLvl;
		critChance = critChance * critChanceLvl;
		atackSpeed = atackSpeed * atackSpeedLvl;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public int getDamageLvl(){

		return PlayerPrefs.GetInt((weaponName + "dmg"));

	}

	public void setDamageLvl(int value){

		PlayerPrefs.GetInt((weaponName + "dmg"));
		damage = damage * damageLvl;


	}

	public int getAtackSpeedLvl(){
		
		return PlayerPrefs.GetInt((weaponName + "speed"));

	}

	public void setAtackSpeedLvl(int value){
		
		PlayerPrefs.SetInt((weaponName + "speed"),value);
		atackSpeed = atackSpeed * atackSpeedLvl;

	}
	

	public int getCritChanceLvl(){
		
		return PlayerPrefs.GetInt((weaponName + "crit"));

	}

	public void setCritChanceLvl(int value){
		
		PlayerPrefs.SetInt((weaponName + "crit"),value);
		critChance = critChance * critChanceLvl;

	}

	public float getDamage(){
		
		return damage;
	}

	public float getCritChance(){
		
		return critChance;
	}

	public float getAtackSpeed(){
		
		return atackSpeed;
	}


	public void Fire(float damageMultiplier,float criticalMultiplier){
	
		float fullDamage = damage * damageMultiplier;
		enemy = GameObject.FindGameObjectWithTag ("Enemy");

		if (enemy) {

			if(Random.Range(0,100) <= critChance ){

				fullDamage = fullDamage * criticalMultiplier;

			}
			enemy.GetComponent<Enemy> ().TakeDamage (fullDamage);

			//spawn a bulllet and make it go to enemy. transform.position




		}



	
	}
	
}
