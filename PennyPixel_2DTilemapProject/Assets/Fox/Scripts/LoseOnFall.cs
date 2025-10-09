using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* Prototype4
* Makes player lose when they fall at a certain point
*/
public class LoseOnFall : MonoBehaviour
{
    public float lowestY;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowestY)
        {
            UIManager.gameOver = true;
        }
    }
}
