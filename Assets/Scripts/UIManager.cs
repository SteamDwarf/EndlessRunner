using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cointText;
    [SerializeField] private GameObject restartMenu;
    [SerializeField] private TextMeshProUGUI restartCoinsText;

    void Start()
    {
        cointText.text = "0";
    }

    public void UpdateCoinText(int coinCount) 
    {
        cointText.text = coinCount.ToString();
    }

    public void ShowRestartMenu(float coinsCount) 
    {
        restartMenu.SetActive(true);
        restartCoinsText.text = coinsCount + " <sprite=0>";
    }
}
