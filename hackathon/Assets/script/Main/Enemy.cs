using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float maxHealth;
	private float health;
	public float money;
	public float level;

	private float x;
	private Transform bar;
	public float speed;

	public Transform movePoint;
	private GameObject player;

	private GameObject background;


	private GameObject behaviour;

	// Use this for initialization
	void Start () {

		maxHealth = 100;
		money = 100;
		speed = 2;
		var auxPoint = GameObject.FindGameObjectWithTag ("Point");
		movePoint = auxPoint.transform;

		behaviour = GameObject.FindGameObjectWithTag ("Behaviour");
		print("I am alive");
		level = behaviour.GetComponent<GameBehaviour> ().level;
		maxHealth = maxHealth * (level +1);
		health = maxHealth;
		money = money * (level + 1);
		bar = transform.FindChild ("LifeBar");
		x = bar.transform.localScale.x;
		player = GameObject.FindGameObjectWithTag ("Player");
		background = GameObject.FindGameObjectWithTag("Background");

	
	}




	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, movePoint.position, step);
		if (transform.position.x == movePoint.position.x) {
		
			player.GetComponent<Player> ().canShoot = true;

		} else {
			background = GameObject.FindGameObjectWithTag("Background");

		}
	}


	public void TakeDamage(float damage){

		health = health - damage;

		float mult = health / maxHealth;
		print (damage);

		bar.localScale = new Vector3(x * mult ,bar.localScale.y,bar.localScale.z);

		if (health <= 0) {

			player.GetComponent<Player>().canShoot = false;
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
