using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* Goblin
* Assignment 6
* Code for player to attack Goblin subclass of EnemyBase
*/
public class Goblin : EnemyBase
{
    protected override void Die()
    {
        Debug.Log("Goblin died!");
        Destroy(gameObject);
    }
}

