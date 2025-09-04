using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnceHit : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager2.score++;
        }
    }
}
