using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* Target
* Assignment 6
* Code for target getting shot at taking damage and if health is below 0, it is destroyed
*/
public class Target : MonoBehaviour
{
    public float health = 50f;    


    public void TakeDamage(float amount)
    {
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
