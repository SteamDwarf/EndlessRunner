using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private UIManager uIManager;
    private int coinsCount;

    private void Awake() 
    {
        uIManager = gameObject.GetComponent<UIManager>();
        coinsCount = 0;
    }

    public void GetCoin() 
    {
        coinsCount += 1;
        uIManager.UpdateCoinText(coinsCount);
    }
}
