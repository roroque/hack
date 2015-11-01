using UnityEngine;
using System.Collections;

public class GameBehaviour : MonoBehaviour {

	[System.Serializable]
	public class GameObjectList{


		public GameObject[] enemies;

	}

	public float money;
	public int caps;
	public int level;
	public GameObjectList[] enemiesList;
	public GameObject[] bosses;


	

	// Use this for initialization
	void Start () {
		money = PlayerPrefs.GetFloat ("money", 0.0F);
		caps = PlayerPrefs.GetInt ("caps", 0);
		level = PlayerPrefs.GetInt ("level", 0);
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void AddMoney(float receive){

		money = money + receive;
		PlayerPrefs.SetFloat ("money", money);
	}

	public void AddEnemy(){
		int size = enemiesList[level].enemies.Length - 1;
		int selected = Random.Range (0, size);
		Instantiate (enemiesList[level].enemies[selected]);
		//make enemy go to the center of the screen
		//set player as running so it will not shoot

	}

	public void CallBoss(){
		Destroy(GameObject.FindGameObjectWithTag ("Enemy"));
		Instantiate (bosses [level]);



	}

	public void AddLevel(){

		level++;
		AddEnemy();

	}



}
