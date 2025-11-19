using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
* Mimi Davis
* Challenge4
* Code for when the enemy prefab hits the player goal, text for losing the game pops up with the option to retry
*/
public class LoseScript : MonoBehaviour
{
    public Text loseText;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            loseText.gameObject.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
         if (loseText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
}
