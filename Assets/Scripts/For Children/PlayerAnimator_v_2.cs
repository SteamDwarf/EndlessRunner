using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator_v_2 : MonoBehaviour
{
    private Animator animator;
    private PlayerController_v_3 playerController;
    private void Awake() 
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = gameObject.GetComponent<PlayerController_v_3>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsJumping", !playerController.IsGrounded());
    }
}