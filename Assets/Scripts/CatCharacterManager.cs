using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatCharacterManager : MonoBehaviour
{
  
    public CharacterDatabase characterDB;
    
    public TextMeshProUGUI nameText;
    public RawImage catSprite;
    
    private int selectedCat = 0;
    void Start()
    {
        //Saves the character selection 
        if(PlayerPrefs.HasKey("SelectedCat"))
        {
           Load();
        }
       
        UpdateCat(selectedCat);
    }

    //Next button when choosing a character, it loops back to the other characters
    public void NextOption()
    {
        selectedCat++;

        if (selectedCat >= characterDB.CharacterCount)
        {
            selectedCat = 0;
        }

        UpdateCat(selectedCat);
        Save();
    }

    //Prev button when choosing a character, it loops back to the other characters
    public void PrevOption()
    {
        selectedCat--;

        if (selectedCat < 0)
        {
            selectedCat = characterDB.CharacterCount - 1;
        }
        
        UpdateCat(selectedCat);
        Save();
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
