using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject //To store the list of the cat characters data 
{
    //To assign the characters
    public CatCharacter[] character;

    //How many characters are in the list
    public int CharacterCount
    {
        get
        {
            return character.Length;
        }
    }
  
    //Selects the character from the list
    public CatCharacter GetCatCharacter(int index)
    {
        return character[index];
    }
}
