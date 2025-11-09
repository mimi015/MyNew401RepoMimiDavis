using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* Ogre
* Assignment 6
* Code for Ogre subclass from EnemyBase
*/
public class Ogre : EnemyBase
{
    protected override void Die()
    {
        Debug.Log("Goblin died!");
        Destroy(gameObject);
    }
}
