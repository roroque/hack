using UnityEngine;
using System.Collections;

public class UpgradeScreen : MonoBehaviour {


	private string weapon;
	public GameObject[] weapons;
	private GameObject selected;
	private GameObject player;


	private float	playerDamage;
	private float playerDamageLvlCost;
	
	private float	playerAtackSpeed;
	private float playerAtackSpeedLvlCost;
	
	private float	playerCritical;
	private float playerCriticalLvlCost;


	private int	weaponDamageLvl;
	private float weaponDamageLvlCost;

	private int	weaponAtackSpeedLvl;
	private float weaponAtackSpeedLvlCost;

	private int	weaponCriticalLvl;
	private float weaponCriticalLvlCost;

		
	private float money;


	




	// Use this for initialization
	void Start () {

		weapon =  PlayerPrefs.GetString("equipped");
		for (int i = 0; i < weapons.Length; i++) {

			if(weapons[i].GetComponent<WeaponSystem>().weaponName == weapon){

				selected = Instantiate(weapons[i]);
				weaponDamageLvl = selected.GetComponent<WeaponSystem>().getDamageLvl();
				weaponAtackSpeedLvl = selected.GetComponent<WeaponSystem>().getAtackSpeedLvl();
				weaponCriticalLvl = selected.GetComponent<WeaponSystem>().getCritChanceLvl();

			}
		}
		money = PlayerPrefs.GetFloat ("money", 0.0F);

		playerAtackSpeed = PlayerPrefs.GetFloat("atackSpeed",1.0f);
		playerDamage = PlayerPrefs.GetFloat("baseDamage",1.0f);
		playerCritical = PlayerPrefs.GetFloat("criticalChance",1.5f);

	
	}

	// Update is called once per frame
	void Update () {
	
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
			playerAtackSpeed++;
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
			playerCritical++;
			money = money - playerCriticalLvlCost;
			PlayerPrefs.SetFloat("criticalChance",playerCritical);
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		playerCriticalLvlCost = playerCriticalLvlCost * playerCritical;
		
	}




//WEAPON UPGRADES

	public void UpgradeWeaponDamage(){

		if(money >= weaponDamageLvlCost)
		{
			weaponDamageLvl++;
			selected.GetComponent<WeaponSystem>().setDamageLvl(weaponDamageLvl);
			money = money - weaponDamageLvlCost;
			PlayerPrefs.SetFloat ("money", money);

		}

		//increase cost
		weaponDamageLvlCost = weaponDamageLvlCost * weaponDamageLvl;

	}



	public void UpgradeWeaponAtackSpeed(){
		
		if(money >= weaponAtackSpeedLvlCost)
		{
			weaponAtackSpeedLvl++;
			selected.GetComponent<WeaponSystem>().setDamageLvl(weaponAtackSpeedLvl);
			money = money - weaponAtackSpeedLvlCost;
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		weaponAtackSpeedLvlCost = weaponAtackSpeedLvlCost * weaponAtackSpeedLvl;
		
	}





	public void UpgradeWeaponCritical(){
		
		if(money >= weaponCriticalLvlCost)
		{
			weaponCriticalLvl++;
			selected.GetComponent<WeaponSystem>().setDamageLvl(weaponCriticalLvl);
			money = money - weaponCriticalLvlCost;
			PlayerPrefs.SetFloat ("money", money);
			
		}
		
		//increase cost
		weaponCriticalLvlCost = weaponCriticalLvlCost * weaponCriticalLvl;
		
	}








}
