using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator_v_3 : MonoBehaviour
{
    private Animator animator;
    private PlayerController_v_4 playerController;
    private void Awake() 
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = gameObject.GetComponent<PlayerController_v_4>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsJumping", !playerController.IsGrounded());
        animator.SetInteger("Move", (int)playerController.playerMoveState);

    }

    public void PlayFallAnimation() 
    {
        animator.SetTrigger("Collide");
    }
}
