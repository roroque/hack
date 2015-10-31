using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public float health;
	public float money;
	public float level;
	
	
	private GameObject behaviour;
	
	// Use this for initialization
	void Start () {
		
		behaviour = GameObject.FindGameObjectWithTag ("Behaviour");
		print("I am fucking alive");
		level = behaviour.GetComponent<GameBehaviour> ().level;
		health = health * level;
		money = money * level;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void TakeDamage(float damage){
		
		health = health - damage;
		
		if (health <= 0) {
			

			print("i am fucking dead");
			behaviour.GetComponent<GameBehaviour>().AddLevel();
			Destroy (gameObject);
		}
		
		
		
	}

}
