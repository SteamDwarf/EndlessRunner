using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum PlayerControllerNum 
{
    FirstPlayer,
    SecondPlayer
}

public class PlayerControllerForTwo : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private PlayerControllerNum playerNum;

    string horizontalAxis;
    string verticalAxis;


    void Start()
    {
        if(playerNum == PlayerControllerNum.FirstPlayer) 
        {
            horizontalAxis = "Horizontal1";
            verticalAxis = "Vertical1";
        }
        else 
        {
            horizontalAxis = "Horizontal2";
            verticalAxis = "Vertical2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        float rotateMoving = Input.GetAxis(horizontalAxis);
        float forwardMoving = Input.GetAxis(verticalAxis);

        //transform.Translate(Vector3.forward * forwardMoving);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardMoving);
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed * rotateMoving);

    }
}
