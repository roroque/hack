using UnityEngine;
using System.Collections;

public class UpgradeScreen : MonoBehaviour {


	private string weapon;
	public GameObject[] weapons;
	public GameObject selected;
	private GameObject player;


	public float	playerDamage;
	public float playerDamageLvlCost;
	
	public float	playerAtackSpeed;
	public float playerAtackSpeedLvlCost;
	
	public float	playerCritical;
	public float playerCriticalLvlCost;


	public int	weaponDamageLvl;
	public float weaponDamageLvlCost;

	public int	weaponAtackSpeedLvl;
	public float weaponAtackSpeedLvlCost;

	public int	weaponCriticalLvl;
	public float weaponCriticalLvlCost;

		
	public float money;
	public int caps;


	




	// Use this for initialization
	void Start () {

		weapon =  PlayerPrefs.GetString("equipped","weapon1");
		for (int i = 0; i < weapons.Length; i++) {

			if(weapons[i].GetComponent<WeaponSystem>().weaponName == weapon){

				selected = Instantiate(weapons[i]);
				weaponDamageLvl = selected.GetComponent<WeaponSystem>().getDamageLvl();
				weaponAtackSpeedLvl = selected.GetComponent<WeaponSystem>().getAtackSpeedLvl();
				weaponCriticalLvl = selected.GetComponent<WeaponSystem>().getCritChanceLvl();

			}
		}
		money = PlayerPrefs.GetFloat ("money", 0.0F);
		caps = PlayerPrefs.GetInt ("caps", 0);

		playerAtackSpeed = PlayerPrefs.GetFloat("atackSpeed",1.0f);
		playerDamage = PlayerPrefs.GetFloat("baseDamage",1.0f);
		playerCritical = PlayerPrefs.GetFloat("criticalChance",1.5f);

	
	}

	// Update is called once per frame
	void Update () {
		playerAtackSpeed = PlayerPrefs.GetFloat("atackSpeed",1.0f);
		playerDamage = PlayerPrefs.GetFloat("baseDamage",1.0f);
		playerCritical = PlayerPrefs.GetFloat("criticalChance",1.5f);
	
	}

//PLAYER UPGRADES

	public void UpgradePlayerDamage(){
		
		if(money >= playerDamageLvlCost)
		{
			//increments damage
			playerDamage++;
			PlayerPrefs.SetFloat("baseDamage",playerDamage);
			money = money - playerDamageLvlCost;
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		playerDamageLvlCost = playerDamageLvlCost * playerDamage;
		
	}
	
	
	
	public void UpgradePlayerAtackSpeed(){
		
		if(money >= playerAtackSpeedLvlCost)
		{

			playerAtackSpeed = playerAtackSpeed + 1;

			PlayerPrefs.SetFloat("atackSpeed",playerAtackSpeed);
			money = money - playerAtackSpeedLvlCost;
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		playerAtackSpeedLvlCost = playerAtackSpeedLvlCost * playerAtackSpeed;
		
	}
	
	
	
	

	public void UpgradePlayerCritical(){
		
		if(money >= playerCriticalLvlCost)
		{
			playerCritical = playerCritical + 1;
			money = money - playerCriticalLvlCost;
			PlayerPrefs.SetFloat("criticalChance",playerCritical);
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		playerCriticalLvlCost = playerCriticalLvlCost * playerCritical;
		
	}




//WEAPON UPGRADES

	public void UpgradeWeaponDamage(){
	
		selected = GameObject.FindGameObjectWithTag("Weapon");

		if(money >= weaponDamageLvlCost)
		{
			weaponDamageLvl++;
			selected.gameObject.GetComponent<WeaponSystem>().setDamageLvl(weaponDamageLvl);
			money = money - weaponDamageLvlCost;
			PlayerPrefs.SetFloat ("money", money);

		}

		//increase cost
		weaponDamageLvlCost = weaponDamageLvlCost * weaponDamageLvl;

	}



	public void UpgradeWeaponAtackSpeed(){
		selected = GameObject.FindGameObjectWithTag("Weapon");


		if(money >= weaponAtackSpeedLvlCost)
		{
			weaponAtackSpeedLvl++;
			selected.gameObject.GetComponent<WeaponSystem>().setAtackSpeedLvl(weaponAtackSpeedLvl);
			money = money - weaponAtackSpeedLvlCost;
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		weaponAtackSpeedLvlCost = weaponAtackSpeedLvlCost * weaponAtackSpeedLvl;
		
	}





	public void UpgradeWeaponCritical(){
		selected = GameObject.FindGameObjectWithTag("Weapon");


		
		if(money >= weaponCriticalLvlCost)
		{
			weaponCriticalLvl++;
			selected.gameObject.GetComponent<WeaponSystem>().setCritChanceLvl(weaponCriticalLvl);
			money = money - weaponCriticalLvlCost;
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		weaponCriticalLvlCost = weaponCriticalLvlCost * weaponCriticalLvl;
		
	}

	public void GoToAnimation(){
		
		Application.LoadLevel("animation");
		
	}


	public void GoToCompraArma(){
		
		Application.LoadLevel("compraArma");
		
	}








}
