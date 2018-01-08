using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement playerMovement;
    private int hit = 0;
    public Text obstaclesHit;
	void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Obstacle"))
        {
            playerMovement.enabled = false;
            obstaclesHit.text = "Hit: " + ++hit;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
