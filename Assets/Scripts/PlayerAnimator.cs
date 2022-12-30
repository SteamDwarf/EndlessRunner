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
    }

    public void PlayFallAnimation() 
    {
        animator.SetBool("IsFall", true);
    }
}
