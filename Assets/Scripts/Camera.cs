using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 cameraOffset;

    private float startYPos;
  

    private void Awake() 
    {
        startYPos = player.transform.position.y + cameraOffset.y;
    }

    void LateUpdate() 
    {
        Vector3 newPos = player.transform.position + cameraOffset;

        newPos.y = startYPos;
        transform.position = newPos;
    }
}
