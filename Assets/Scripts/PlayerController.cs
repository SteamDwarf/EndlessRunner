using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpPower;
    [SerializeField] private float sideMoveSpeed;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float roadLanesWidth;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;


    private Rigidbody rb;
    private bool isPressedJump = false;
    private Vector3 targetPos;
    private bool isAlive = true;

    private void Awake() 
    {
        rb = gameObject.GetComponent<Rigidbody>();
        targetPos = transform.position;
    }

    void Update()
    {
        if(!isAlive) return;

        if(IsGrounded()) 
        {
            if(Input.GetKeyDown(leftKey)) targetPos.x = Mathf.Clamp(transform.position.x - roadLanesWidth, 6, 19);
            if(Input.GetKeyDown(rightKey)) targetPos.x = Mathf.Clamp(transform.position.x + roadLanesWidth, 6, 19);

            if(Vector3.Distance(transform.position, targetPos) > 0.1) 
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos, sideMoveSpeed * Time.deltaTime);
            }
        }
        isPressedJump = Input.GetButtonDown("Jump") || isPressedJump;
    }

    private void FixedUpdate() 
    {
        if(!isAlive) return;

        if(isPressedJump && IsGrounded()) Jump();
    }

    private void Jump() 
    {
        rb.AddForce(new Vector3(0, jumpPower * Time.deltaTime, 0), ForceMode.Impulse);
        isPressedJump = false;
    }

    public bool IsGrounded() 
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        return Physics.Raycast(ray, 0.2f, groundLayer);
    }

    public void Stop() 
    {
        isAlive = false;
    }

    public void Punch() 
    {
        //rb.AddForce(new Vector3(0, 0, -2000));
    }
}
