using UnityEngine;
using System.Collections;

public class WeaponSystem : MonoBehaviour {

	public float damage;
	public float atackSpeed;
	public float critChance;
	public GameObject projectile;

	private GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
