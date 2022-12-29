using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints;

    public void SpawnObject(GameObject spawnedObject) 
    {
        if(spawnPoints.Count > 0) 
        {
            int randIndex = Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[randIndex];

            GameObject.Instantiate(spawnedObject, spawnPoint.position, Quaternion.identity, transform);
            spawnPoints.Remove(spawnPoint);
        }
    }
}
