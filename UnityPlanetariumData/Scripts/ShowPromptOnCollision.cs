using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPromptOnCollision : MonoBehaviour
{
    GameObject player;
    bool playerInRange;
    public GameObject prompt;
    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false;
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }

    void Update()
    {
        prompt.SetActive(playerInRange);
    }
}