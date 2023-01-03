using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision_v_2 : MonoBehaviour
{
    private GameManager_v_2 gameManager;
    private PlayerController_v_4 playerController;
    private PlayerAnimator_v_3 playerAnimator;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager_v_2>().GetComponent<GameManager_v_2>();
        playerController = gameObject.GetComponent<PlayerController_v_4>();
        playerAnimator = gameObject.GetComponent<PlayerAnimator_v_3>();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Obstacle") 
        {
            Vector3 direction = transform.position - other.transform.position;

            gameManager.CollideWithObstacle();
            playerAnimator.PlayFallAnimation();
            playerController.Stop();
        }
    }
}
