using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 cameraOffset;

    private float startYPos;


    void LateUpdate() 
    {
        if(player == null) return;
        
        Vector3 newPos = player.transform.position + cameraOffset;

        newPos.y = startYPos;
        transform.position = newPos;
    }

    public void SetPlayer(GameObject player) 
    {
        this.player = player;
        startYPos = player.transform.position.y + cameraOffset.y;
    }
}
