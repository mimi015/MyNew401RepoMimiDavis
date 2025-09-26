using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* TriggerZoneAddScore
* Prototype3
* Code makes the triggerzone add a score to the new text at the top of the scene
*/

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;


    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
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
