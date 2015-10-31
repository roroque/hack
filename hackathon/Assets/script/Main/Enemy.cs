using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float maxHealth;
	private float health;
	public float money;
	public float level;

	private float x;
	private Transform bar;


	private GameObject behaviour;

	// Use this for initialization
	void Start () {

		behaviour = GameObject.FindGameObjectWithTag ("Behaviour");
		print("I am alive");
		level = behaviour.GetComponent<GameBehaviour> ().level;
		maxHealth = maxHealth * (level +1);
		health = maxHealth;
		money = money * (level + 1);
		bar = transform.FindChild ("LifeBar");
		x = bar.transform.localScale.x;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void TakeDamage(float damage){

		health = health - damage;

		float mult = health / maxHealth;
		print (damage);

		bar.localScale = new Vector3(x * mult ,bar.localScale.y,bar.localScale.z);

		if (health <= 0) {

			Respawn();
			Destroy (gameObject);
			print("i am dead");

		}



	}


	void Respawn ()
	{
	
		behaviour.GetComponent<GameBehaviour> ().AddMoney (money);
		behaviour.GetComponent<GameBehaviour> ().AddEnemy ();
	
	}





}
