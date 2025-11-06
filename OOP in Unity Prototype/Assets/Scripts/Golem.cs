using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;
    
    // Start is called before the first frame update
    protected override void Awake()
    {
      base.Awake();
      health = 5;  
      GameManager.Instance.score += 2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took" + amount + "points of damage!");

        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
