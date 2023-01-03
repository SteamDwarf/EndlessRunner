using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerController))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private PlayerController playerController;
    // Start is called before the first frame update
    private void Awake() 
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsJumping", !playerController.IsGrounded());
        animator.SetInteger("Move", (int)playerController.SideMoveState);
    }

    public void PlayFallAnimation() 
    {
        animator.SetTrigger("Collide");
    }
}
