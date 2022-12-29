using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cointText;
    void Start()
    {
        cointText.text = "0";
    }

    public void UpdateCoinText(int coinCount) 
    {
        cointText.text = coinCount.ToString();
    }
}
