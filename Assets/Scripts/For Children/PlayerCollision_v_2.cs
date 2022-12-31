using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController_v_3))]
public class PlayerCollision_v_2 : MonoBehaviour
{
    private GameManager_v_1 gameManager;
    private PlayerController_v_3 playerController;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager_v_1>().GetComponent<GameManager_v_1>();
        playerController = gameObject.GetComponent<PlayerController_v_3>();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Obstacle") 
        {
            Vector3 direction = transform.position - other.transform.position;

            gameManager.CollideWithObstacle();
            playerController.Stop();
        }
    }
}
