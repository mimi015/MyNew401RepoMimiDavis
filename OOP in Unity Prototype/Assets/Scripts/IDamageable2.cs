using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* IDamageable2
* Assignment 6
* Code for TakeDamage to take place for base classes
*/
public interface IDamageable2
{
    int Health { get; set; } 
    void TakeDamage(int damageAmount); 
}

