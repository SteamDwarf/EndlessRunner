using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 thirdPlayerOffset;
    [SerializeField] private Vector3 firstPlayerOffset;

    private bool isThirdPlayerView = true;

    // Update is called once per frame
    private void Update() 
    {
        /* if(Input.GetButtonDown("Jump"))
        {
            isThirdPlayerView = !isThirdPlayerView;
        } */
    }

    void LateUpdate() 
    {
        if(isThirdPlayerView) 
        {
            transform.position = player.transform.position + thirdPlayerOffset;
        }
        else 
        {
            transform.position = player.transform.position + firstPlayerOffset;
        }
    }
}
