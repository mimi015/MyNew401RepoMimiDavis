using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : EnemyBase
{
    protected override void Die()
    {
        Debug.Log("Goblin died!");
        Destroy(gameObject);
    }
}

