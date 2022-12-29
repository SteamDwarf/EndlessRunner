using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRoad : MonoBehaviour
{
    private SpawnManager spawnManager;

    private void Awake() 
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "CarBackTrigger") 
        {
            spawnManager.RoadTriggering();
        }    
    }
}
