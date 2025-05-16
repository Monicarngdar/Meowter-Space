using UnityEngine;

public class GameManager : MonoBehaviour
{
    //The access to the Game Manager 
    public static GameManager Instance;
    
    //To track when the player is game over
    public bool isGameOver = false;

    //Ensures
    private void Awake()
    {
        if(Instance == null) Instance = this; //If no game manager it becomes null
        else Destroy(gameObject); //Destroys the game object
    }

    public void GameOver()
    {
        isGameOver = true; //Sets the game over to active
        Time.timeScale = 0f; //Freezes the game
    }
}
