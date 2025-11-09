using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* Enemy
* Assignment 6
* Code for Enemy class
*/
public abstract class Enemy : MonoBehaviour, IDamageable
{
    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        
        speed = 5f;
        health = 5;

        weapon.damageBonus = 10;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected abstract void Attack(int amount);

    public abstract void TakeDamage(int amount);
    // Update is called once per frame
    void Update()
    {
        
    }
}
