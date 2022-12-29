using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake() 
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        PlayerController playerController;
        if(other.gameObject.TryGetComponent<PlayerController>(out playerController)) 
        {
            gameManager.GetCoin();
            Destroy(gameObject);
        }
    }
}
