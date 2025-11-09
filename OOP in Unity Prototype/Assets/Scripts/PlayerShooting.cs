using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* PlayerShooting
* Assignment 6
* Code for player to be able to destroy enemies from subclasses
*/
public class PlayerShooting : MonoBehaviour
{
    public Camera playerCamera;
    public float shootRange = 100f;
    public int damageAmount = 20;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, shootRange))
        {
            Debug.Log("Hit: " + hit.collider.name);

            IDamageable damageableObject = hit.collider.GetComponent<IDamageable>();
            if (damageableObject != null)
            {
                damageableObject.TakeDamage(damageAmount);
            }
        }
    }
}

