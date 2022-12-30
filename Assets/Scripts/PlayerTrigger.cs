using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private SpawnManager spawnManager;

    private void Awake() 
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "SpawnTrigger") 
        {
            spawnManager.RoadTriggering();
        }    
    }
}
