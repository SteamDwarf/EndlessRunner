using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerController_v_2))]
public class PlayerAnimator_v_1 : MonoBehaviour
{
    private Animator animator;
    private PlayerController_v_2 playerController;
    private void Awake() 
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = gameObject.GetComponent<PlayerController_v_2>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsJumping", !playerController.IsGrounded());
    }
}
