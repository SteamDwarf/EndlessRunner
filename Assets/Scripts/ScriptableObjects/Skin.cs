using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Skin")]
public class Skin : ScriptableObject
{
    [SerializeField] private string skinName;
    [SerializeField] private float price;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Sprite skinSprite;

    public GameObject Prefab => prefab;
    public float Price => price;
    public string Name => skinName;
    public Sprite Sprite => skinSprite;
}
