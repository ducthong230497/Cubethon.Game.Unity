using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {
    public PlayerMovement playerMovement;

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
        playerMovement.enabled = false; 
    }
}
