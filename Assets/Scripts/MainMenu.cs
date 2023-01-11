using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUIContainer;
    [SerializeField] private GameObject shopUIContainer;
    public void StartGame() 
    {
        SceneManager.LoadScene((int)Scenes.Game);
    }

    public void OpenShop() 
    {
        mainMenuUIContainer.SetActive(false);
        shopUIContainer.SetActive(true);
    }

    public void OpenMainMenu() 
    {
        mainMenuUIContainer.SetActive(true);
        shopUIContainer.SetActive(false);
    }
}
