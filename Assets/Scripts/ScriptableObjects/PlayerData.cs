using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerData")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private string skinName;
    [SerializeField] private int coinsCount;

    public string SkinName {get {return skinName;} set {skinName = value;}}
    public int CoinsCount {get {return coinsCount;} set {coinsCount = value;}}
}
