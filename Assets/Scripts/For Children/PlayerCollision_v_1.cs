using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision_v_1 : MonoBehaviour
{
    private GameManager_v_1 gameManager;
    private PlayerController_v_2 playerController;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager_v_1>().GetComponent<GameManager_v_1>();
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Obstacle") 
        {
            Vector3 direction = transform.position - other.transform.position;

            gameManager.CollideWithObstacle();
        }
    }
}