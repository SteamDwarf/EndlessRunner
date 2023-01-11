using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Character")]
public class Character : ScriptableObject
{
    [SerializeField] private string skinName;
    [SerializeField] private GameObject prefab;

    public GameObject Prefab => prefab;
    public string Name => name;
}
