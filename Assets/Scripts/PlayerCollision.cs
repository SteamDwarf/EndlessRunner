using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private Player player;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
        player = gameObject.GetComponent<Player>();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Obstacle") 
        {
            Vector3 direction = transform.position - other.transform.position;

            gameManager.CollideWithObstacle();
            player.ObstacleCollided();
        }
    }
}
