using UnityEngine;
using UnityEngine.UI;

public class CatCharacterSpawn : MonoBehaviour
{
    public CharacterDatabase characterDB;
    public SpriteRenderer catSprite;
    
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
    
    private void UpdateCat(int selectedCat)
    {
        CatCharacter catCharacter = characterDB.GetCatCharacter(selectedCat);
        catSprite.sprite = catCharacter.catSpaceSprite;
    }

    private void Load()
    {
        selectedCat = PlayerPrefs.GetInt("SelectedCat");
    }
   
}
