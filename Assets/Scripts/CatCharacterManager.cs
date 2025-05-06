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
        if(PlayerPrefs.HasKey("SelectedCat"))
        {
            selectedCat = 0;
        }

        else
        {
            Load();
        }
        
        UpdateCat(selectedCat);
    }

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

    private void UpdateCat(int selectedCat)
    {
        CatCharacter catCharacter = characterDB.GetCatCharacter(selectedCat);
        catSprite.texture = catCharacter.characterSprite;
        nameText.text = catCharacter.characterName;
    }

    private void Load()
    {
        selectedCat = PlayerPrefs.GetInt("selectedCat");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("SelectedCat", selectedCat);
    }
}
