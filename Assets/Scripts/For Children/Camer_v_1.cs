using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_v_1 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 cameraOffset;

    void LateUpdate() 
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
