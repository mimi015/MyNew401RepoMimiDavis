using System.Collections;
using UnityEngine;
/*
* Mimi Davis
* Weapon
* Assignment 6
* Code for Weapon that is unused in current game but gives damage bonus to enemies in Enemy base class
*/
public class Weapon : MonoBehaviour
{
    
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon.");
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
