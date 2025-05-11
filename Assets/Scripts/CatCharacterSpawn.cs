using UnityEngine;
using UnityEngine.UI;

public class CatCharacterSpawn : MonoBehaviour
{
    public CharacterDatabase characterDB; //Reference to the CharacterDatabase script 
    public SpriteRenderer catSprite; //To display the characters name
    
    private int selectedCat = 0; //Index of character selected
    void Start()
    {
        //Saves the character selection 
        if(PlayerPrefs.HasKey("SelectedCat"))
        {
            Load(); //Loads the save character selected
        }
       
        UpdateCat(selectedCat); //Updates the character and name
    }
    
    //Updates the character 
    private void UpdateCat(int selectedCat)
    {
        CatCharacter catCharacter = characterDB.GetCatCharacter(selectedCat);
        catSprite.sprite = catCharacter.catSpaceSprite;
    }

    //Selects the character into the prefab
    private void Load()
    {
        selectedCat = PlayerPrefs.GetInt("SelectedCat");
    }
   
}
