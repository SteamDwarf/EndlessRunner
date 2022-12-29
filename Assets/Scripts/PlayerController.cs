using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;


    private SpawnManager spawnManager;
    private Rigidbody rb;
    private float rotateMoving;
    private bool isPressedJump = false;

    private void Awake() 
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        rotateMoving = Input.GetAxis("Horizontal");
        isPressedJump = Input.GetButtonDown("Jump") || isPressedJump;
    }

    private void FixedUpdate() 
    {
        Vector3 moveVector = transform.forward * Time.deltaTime * speed;

        moveVector.y = rb.velocity.y;
        rb.velocity = moveVector;
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed * rotateMoving);

        if(isPressedJump && IsGrounded()) Jump();
    }

    private void Jump() 
    {
        rb.AddForce(new Vector3(0, jumpPower * Time.deltaTime, 0), ForceMode.Impulse);
        isPressedJump = false;
    }

    private bool IsGrounded() 
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        return Physics.Raycast(ray, 0.2f, groundLayer);
    }

}
