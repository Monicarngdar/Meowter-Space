using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatCharacterManager : MonoBehaviour
{
   //To attach the CharacterDatabase
    public CharacterDatabase characterDB;
    //Name of the character
    public TextMeshProUGUI nameText;
    //Characters sprite
    public RawImage catSprite;
    
    //Sets as a  prefab to change the character
    private int selectedCat = 0;
    void Start()
    {
        //Saves the character selection 
        if(PlayerPrefs.HasKey("SelectedCat"))
        {
           Load(); //Loads the save character selected
        }
       
        UpdateCat(selectedCat); //Updates the character and name 
    }

    //Next button when choosing a character, it loops back to the other characters
    public void NextOption()
    {
        selectedCat++; //to click next

        if (selectedCat >= characterDB.CharacterCount)
        {
            selectedCat = 0;
        }

        UpdateCat(selectedCat); //Updates the character selected
        Save(); //Saves it
    }

    //Prev button when choosing a character, it loops back to the other characters
    public void PrevOption()
    {
        selectedCat--; //to go back

        //loops nack to the start
        if (selectedCat < 0)
        {
            selectedCat = characterDB.CharacterCount - 1;
        }
        
        UpdateCat(selectedCat);  //Updates the character selected
        Save(); //Saves it
    }

    //Updates the characters name and image
    private void UpdateCat(int selectedCat)
    {
        CatCharacter catCharacter = characterDB.GetCatCharacter(selectedCat);
        catSprite.texture = catCharacter.characterSprite;
        nameText.text = catCharacter.characterName;
    }

    //Loads the character from the prefab
    private void Load()
    {
        selectedCat = PlayerPrefs.GetInt("SelectedCat");
    }

    //Selects the character from the prefab
    private void Save()
    {
        PlayerPrefs.SetInt("SelectedCat", selectedCat);
    }
}
