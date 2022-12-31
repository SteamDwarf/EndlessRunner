using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_v_1 : MonoBehaviour
{
    [SerializeField] private RoadMover roadMover;

    public void CollideWithObstacle() 
    {
        roadMover.Stop();
    }
}
