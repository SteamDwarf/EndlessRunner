using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> roads;
    [SerializeField] private List<GameObject> roadPrefabs;
    [SerializeField] private int startRoadsCount;
    [SerializeField] private GameObject roadParent;
    [SerializeField] private float roadZOffset;
    [SerializeField] private List<GameObject> obstaclesPrefabs;
    [SerializeField] private int minObstaclesPerRoad;
    [SerializeField] private int maxObstaclesPerRoad;
    [SerializeField] private List<GameObject> coins;
    [SerializeField] private int minCoinsPerRoad;
    [SerializeField] private int maxCoinsPerRoad;

    private void Awake() 
    {
        for (int i = 0; i < startRoadsCount; i++)
        {
            SpawnRoad();
        }
    }

    public void RoadTriggering() 
    {
        SpawnRoad();
        DeleteFirstRoad();
    }

    private void SpawnRoad() 
    {
        GameObject lastRoad = roads[roads.Count - 1];
        Vector3 lastRoadPos = lastRoad.transform.position;
        Vector3 newPos = new Vector3(0, 0, lastRoadPos.z + roadZOffset);
        int roadPrefabInd = Random.Range(0, roadPrefabs.Count);
        GameObject roadPrefab = roadPrefabs[roadPrefabInd];
        GameObject instRoad = GameObject.Instantiate(roadPrefab, newPos, Quaternion.identity, roadParent.transform);

        roads.Add(instRoad);

        SpawnObjects(instRoad, obstaclesPrefabs, minObstaclesPerRoad, maxObstaclesPerRoad);
        SpawnObjects(instRoad, coins, minCoinsPerRoad, maxCoinsPerRoad);
    }

    private void DeleteFirstRoad() 
    {
        GameObject firstRoad = roads[0];

        roads.Remove(firstRoad);
        Object.Destroy(firstRoad);
    }

    private void SpawnObjects(GameObject road, List<GameObject> objectsList, int min, int max) 
    {
        Road roadScript = road.GetComponent<Road>();
        int objectsCount = Random.Range(min, max + 1);
        
        for(int i = 0; i < objectsCount; i++) 
        {
            int randObjectIndex = Random.Range(0, objectsList.Count);
            GameObject randObject = objectsList[randObjectIndex];

            roadScript.SpawnObject(randObject);
        }
        
    }

    /* [SerializeField] private List<GameObject> roads;
    [SerializeField] private List<GameObject> roadPrefabs;
    [SerializeField] private GameObject roadParent;
    [SerializeField] private float roadZOffset;
    [SerializeField] private List<GameObject> obstacles;
    [SerializeField] private int minObstaclesPerRoad;
    [SerializeField] private int maxObstaclesPerRoad;
    [SerializeField] private List<GameObject> coins;
    [SerializeField] private int minCoinsPerRoad;
    [SerializeField] private int maxCoinsPerRoad;


    private void Start() 
    {
        roads = roads.OrderBy(road => road.transform.position.z).ToList();

        for (int i = 0; i < 15; i++)
        {
            SpawnRoad();
        }
    }

    public void RoadTriggering() 
    {
        SpawnRoad();
        DeleteFirstRoad();
    }

    private void SpawnRoad() 
    {
        GameObject lastRoad = roads[roads.Count - 1];
        Vector3 lastRoadPos = lastRoad.transform.position;
        Vector3 newPos = new Vector3(0, 0, lastRoadPos.z + roadZOffset);
        int roadPrefabInd = Random.Range(0, roadPrefabs.Count);
        GameObject roadPrefab = roadPrefabs[roadPrefabInd];
        GameObject instRoad = GameObject.Instantiate(roadPrefab, newPos, Quaternion.identity, roadParent.transform);

        roads.Add(instRoad);

        SpawnObjects(instRoad, obstacles, minObstaclesPerRoad, maxObstaclesPerRoad);
        SpawnObjects(instRoad, coins, minCoinsPerRoad, maxCoinsPerRoad);
    }

    private void DeleteFirstRoad() 
    {
        GameObject firstRoad = roads[0];

        roads.Remove(firstRoad);
        Object.Destroy(firstRoad);
    }

    private void SpawnObjects(GameObject road, List<GameObject> objectsList, int min, int max) 
    {
        Road roadScript = road.GetComponent<Road>();
        int objectsCount = Random.Range(min, max);
        
        for(int i = 0; i < objectsCount; i++) 
        {
            int randObjectIndex = Random.Range(0, objectsList.Count);
            GameObject randObject = objectsList[randObjectIndex];

            roadScript.SpawnObject(randObject);
        }
        
    }
 */
    
}
