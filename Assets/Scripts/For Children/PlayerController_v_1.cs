using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_v_1 : MonoBehaviour
{
    [SerializeField] private float sideMoveSpeed;
    [SerializeField] private float roadLanesWidth;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    private Vector3 targetPos;

    private void Awake() 
    {
        targetPos = transform.position;
    }
    void Update()
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
}
