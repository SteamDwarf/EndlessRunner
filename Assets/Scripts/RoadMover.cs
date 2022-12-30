using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMover : MonoBehaviour
{
    [SerializeField] private float speed;

    private bool isMove = true;

    void Update()
    {
        if(isMove) 
        {
            transform.Translate(-transform.forward * Time.deltaTime * speed);
        }
    }

    public void Stop() 
    {
        isMove = false;
    }
}
