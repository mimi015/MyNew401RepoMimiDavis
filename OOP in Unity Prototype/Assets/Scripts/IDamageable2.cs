using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable2
{
    int Health { get; set; } // Property for health management
    void TakeDamage(int damageAmount); // Method to apply damage
}

