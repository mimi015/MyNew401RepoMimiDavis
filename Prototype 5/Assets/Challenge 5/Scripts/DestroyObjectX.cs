using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* DestroyObjectX
* Prototype 5 Challenge 5
* Destroys food gameobjects
*/
public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
