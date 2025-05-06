using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public CatCharacter[] character;

    public int CharacterCount
    {
        get
        {
            return character.Length;
        }
    }

    public CatCharacter GetCatCharacter(int index)
    {
        return character[index];
    }
}
