using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public int attackDamage = 10;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object can be damaged
        if (other.TryGetComponent(out IDamageable damageableObject))
        {
            damageableObject.TakeDamage(attackDamage);
        }
    }
}

