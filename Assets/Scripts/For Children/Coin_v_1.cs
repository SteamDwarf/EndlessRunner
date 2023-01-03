using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_v_1 : MonoBehaviour
{
    private GameManager_v_2 gameManager;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager_v_2>().GetComponent<GameManager_v_2>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.GetComponent<PlayerController_v_4>()) 
        {
            gameManager.GetCoin();
            Destroy(gameObject);
        }
    }
}
