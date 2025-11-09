using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* EnemyBase
* Assignment 6
* Code for player to attack the IDamageable base class
*/
public abstract class EnemyBase : MonoBehaviour, IDamageable
{
    [SerializeField] protected int health;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public virtual void TakeDamage(int damageAmount) 
    {
        health -= damageAmount;
        Debug.Log(gameObject.name + " took " + damageAmount + " damage. Health: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    protected abstract void Die(); 

}