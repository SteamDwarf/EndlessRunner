using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RoadMover roadMover;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private PlayerCamera playerCamera;
    [SerializeField] private PlayerData playerData;
    
    private UIManager uIManager;
    private CharacterStore skinManager;
    private int coinsCount;

    private void Awake() 
    {
        uIManager = gameObject.GetComponent<UIManager>();
        skinManager = gameObject.GetComponent<CharacterStore>();
        coinsCount = 0;
    }

    private void Start() 
    {
        Character character = skinManager.GetCharacterByName(playerData.SkinName);
        GameObject player = character.Prefab;

        GameObject instPlayer = GameObject.Instantiate(player, startPosition, Quaternion.identity);
        playerCamera.SetPlayer(instPlayer);
        roadMover.Start();
    }

    public void GetCoin() 
    {
        coinsCount += 1;
        uIManager.UpdateCoinText(coinsCount);
    }

    public void CollideWithObstacle() 
    {
        roadMover.Stop();
        uIManager.ShowRestartMenu(coinsCount);
    }

    public void Restart() 
    {
        SceneManager.LoadScene((int)Scenes.Game);
    }
}
