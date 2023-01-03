using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger_v_1 : MonoBehaviour
{
    private SpawnManager_v_2 spawnManager;

    private void Awake() 
    {
        spawnManager = GameObject.FindObjectOfType<SpawnManager_v_2>().GetComponent<SpawnManager_v_2>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "SpawnTrigger") 
        {
            spawnManager.RoadTriggering();
        }    
    }
}
