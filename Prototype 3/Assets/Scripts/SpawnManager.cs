﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Mimi Davis
* SpawnManager
* Prototype3
* Code used to spawn the obstacle prefab
*/

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if(!playerControllerScript.gameOver)
        { 
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
