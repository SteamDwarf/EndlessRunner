using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController controller;
    private PlayerAnimator animator;
    private PlayerCollision collision;
    private PlayerTrigger trigger;

    private void Awake() 
    {
        controller = gameObject.GetComponent<PlayerController>();
        animator = gameObject.GetComponent<PlayerAnimator>();
        collision = gameObject.GetComponent<PlayerCollision>();
        trigger = gameObject.GetComponent<PlayerTrigger>();
    }

    public void ObstacleCollided() 
    {
        controller.Stop();
        animator.PlayFallAnimation();
    }
}
