using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinStore : MonoBehaviour
{
    [SerializeField] private List<Skin> skins;

    public Skin GetSkinByName(string skinName) 
    {
        foreach(Skin skin in skins) 
        {
            if(skin.Name == skinName) return skin;
        }

        return null;
    }

    public int GetSkinIndex(Skin skin) 
    {
        return skins.IndexOf(skin);
    }

    public Skin GetNextSkin(Skin skin) 
    {
        int skinIndex = skins.IndexOf(skin);
        int newSkinIndex = Mathf.Clamp(skinIndex + 1, 0, skins.Count - 1);

        return skins[newSkinIndex];
    }

    public Skin GetPrevSkin(Skin skin) 
    {
        int skinIndex = skins.IndexOf(skin);
        int newSkinIndex = Mathf.Clamp(skinIndex - 1, 0, skins.Count - 1);

        return skins[newSkinIndex];
    }
}
