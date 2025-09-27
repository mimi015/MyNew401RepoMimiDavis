using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Mimi Davis
* TriggerZoneAddScoreX
* Challenge3
* Code makes the triggerzone add a score to the new text at the top of the scene
*/

public class TriggerZoneAddScoreX : MonoBehaviour
{
    private UIManagerX uIManager;

    private bool triggered = false;


    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManagerX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true; 
            uIManager.score++;
        }
    }
}