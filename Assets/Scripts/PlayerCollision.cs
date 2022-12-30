using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerController playerController;
    private PlayerAnimator playerAnimator;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
        playerController = gameObject.GetComponent<PlayerController>();
        playerAnimator = gameObject.GetComponent<PlayerAnimator>();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Obstacle") 
        {
            Vector3 direction = transform.position - other.transform.position;

            gameManager.CollideWithObstacle();
            playerController.Stop();
            playerAnimator.PlayFallAnimation();
            //playerController.Punch();
        }
    }
}
