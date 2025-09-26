using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Mimi Davis
* RepeatBackground
* Prototype3
* Code made for background to repeat as it is moving left
*/

public class RepeatBackground : MonoBehaviour
{

    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }

    }
}
