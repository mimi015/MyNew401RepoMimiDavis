using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnHit : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80f || transform.position.y < -51f)
        {
            ScoreManager2.gameOver = true;
        }
    }
}
