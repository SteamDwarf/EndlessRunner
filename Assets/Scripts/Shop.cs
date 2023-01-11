using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI skinName;
    [SerializeField] private TextMeshProUGUI skinPrice;
    [SerializeField] private Image skinImage;
    [SerializeField] private Transform skinPositionTransform;
    [SerializeField] private PlayerData playerData;
    
    private SkinStore skinStore;
    private GameObject instSkin;
    private Skin skin;

    private void Awake() 
    {
        skinStore = GameObject.FindObjectOfType<SkinStore>().GetComponent<SkinStore>();
    }

    private void Start() 
    {
        Skin startSkin = skinStore.GetSkinByName(playerData.SkinName);
        ShowSkin(startSkin);
    }


    public void NextSkin() 
    {
        Skin newSkin = skinStore.GetNextSkin(skin);
        ShowSkin(newSkin);

    }
    public void PrevSkin() 
    {
        Skin newSkin = skinStore.GetPrevSkin(skin);
        ShowSkin(newSkin);
    }

    public void ChooseSkin() 
    {
        playerData.SkinName = skin.Name;
    }

    private void ShowSkin(Skin newSkin) 
    {
        if(newSkin != null && newSkin != skin) 
        {
            skin = newSkin;

            skinName.text = skin.Name;
            skinPrice.text = skin.Price + " <sprite=0>";
            skinImage.sprite = skin.Sprite;

            if(instSkin != null) Destroy(instSkin);

            instSkin = GameObject.Instantiate(skin.Prefab);
            instSkin.transform.position = skinPositionTransform.position;
        }
    }

}
