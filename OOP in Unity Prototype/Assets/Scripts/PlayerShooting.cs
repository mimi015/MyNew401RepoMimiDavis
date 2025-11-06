using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

