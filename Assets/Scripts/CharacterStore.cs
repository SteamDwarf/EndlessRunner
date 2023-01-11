using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStore : MonoBehaviour
{
    [SerializeField] private List<Character> characters;


    public Character GetCharacterByName(string skinName) 
    {
        foreach(Character character in characters) 
        {
            if(character.Name == skinName) return character;
        }

        return null;
    }
}
