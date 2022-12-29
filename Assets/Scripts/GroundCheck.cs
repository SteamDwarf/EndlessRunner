using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask groundLayer;


    private void Update() 
    {
        Ray ray = new Ray(transform.position, -Vector3.up);

        if(Physics.Raycast(ray, distance, groundLayer)) 
        {
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);
        }
        else 
        {
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);
        }
    }
}
