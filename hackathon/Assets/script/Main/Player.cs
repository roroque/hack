using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float atackSpeed;
	public float baseDamage;
	public float criticalChance;
	public GameObject weapon;

	private float atackRate;

	private float time = 0;

	// Use this for initialization
	void Start () {

		atackSpeed = PlayerPrefs.GetFloat("atackSpeed",1.0f);
		baseDamage = PlayerPrefs.GetFloat("baseDamage",1.0f);
		criticalChance = PlayerPrefs.GetFloat("criticalChance",1.5f);
	
	}
	
	// Update is called once per frame
	void Update () {

		atackRate = 1 /( weapon.GetComponent<WeaponSystem>().atackSpeed * atackSpeed);
		time = time + Time.deltaTime;

		if(time > atackRate ){
			time = 0;
			weapon.GetComponent<WeaponSystem>().Fire(baseDamage,criticalChance);
		}

		if (Input.GetMouseButtonDown(0))
		{
			weapon.GetComponent<WeaponSystem>().Fire(baseDamage,criticalChance);
		}
	
	}
}
