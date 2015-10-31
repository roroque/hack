using UnityEngine;
using System.Collections;

public class GameBehaviour : MonoBehaviour {



	public float money;
	public int caps;
	public int level;
	public GameObject[][] enemies;
	public GameObject[] bosses;
	

	// Use this for initialization
	void Start () {
		money = PlayerPrefs.GetFloat ("money", 0.0F);
		caps = PlayerPrefs.GetInt ("caps", 0);
		level = PlayerPrefs.GetInt ("level", 1);
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void AddMoney(float receive){

		money = money + receive;
		PlayerPrefs.SetFloat ("money", money);
	}

	public void AddEnemy(){
		int size = enemies[level].Length - 1;
		int selected = Random.Range (0, size);
		Instantiate (enemies[level][selected]);
		//make enemy go to the center of the screen
		//set player as running so it will not shoot

	}

	public void CallBoss(){
		Destroy(GameObject.FindGameObjectWithTag ("Enemy"));
		Instantiate (bosses [level]);
		//make booos go to the center of the screen
		//set player as running so it will not shoot
		//start timer to boss


	}

	public void AddLevel(){

		level++;
		AddEnemy();

	}



}
