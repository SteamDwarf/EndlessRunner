using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_v_3 : MonoBehaviour
{
    [SerializeField] private float sideMoveSpeed;
    [SerializeField] private float roadLanesWidth;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;
    [SerializeField] private KeyCode jumpKey = KeyCode.Space;

    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;

    public bool IsAlive {get; private set;}
    private Rigidbody rb;
    private Vector3 targetPos;
    private bool isPressedJump = false;

    private void Awake() 
    {
        rb = gameObject.GetComponent<Rigidbody>();
        targetPos = transform.position;
        IsAlive = true;
    }
    void Update()
    {
        if(!IsAlive) return;

        if(IsGrounded()) 
        {
            if(Input.GetKeyDown(leftKey)) 
            {
                targetPos.x = Mathf.Clamp(transform.position.x - roadLanesWidth, 6, 19);
            }
            if(Input.GetKeyDown(rightKey)) 
            {
                targetPos.x = Mathf.Clamp(transform.position.x + roadLanesWidth, 6, 19);
            }

            if(Vector3.Distance(transform.position, targetPos) > 0.1) 
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos, sideMoveSpeed * Time.deltaTime);
            } 
        }

        isPressedJump = Input.GetKeyDown(jumpKey) || isPressedJump;

    }

    private void FixedUpdate() 
    {
        if(!IsAlive) return;

        if(isPressedJump && IsGrounded()) Jump();
    }

    private void Jump() 
    {
        rb.AddForce(new Vector3(0, jumpPower * Time.deltaTime, 0), ForceMode.Impulse);
        isPressedJump = false;
    }

    public bool IsGrounded() 
    {
        Ray ray = new Ray(groundCheck.position, -Vector3.up);
        return Physics.Raycast(ray, 0.2f, groundLayer);
    }

    public void Stop() 
    {
        IsAlive = false;
    }
}
