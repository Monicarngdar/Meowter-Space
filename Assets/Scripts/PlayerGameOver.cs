using UnityEngine;
using UnityEngine.SceneManagement; //Loads in the scene

public class PlayerGameOver : MonoBehaviour
{
    //Add the game over screen panel
    public GameObject  gameOverPanel;
    
    public AudioClip buttonClickSound;
    private AudioSource audioSource;

   //Audio Variables
    void Start()
    {
        //Audio source component to be placed
        audioSource = GetComponent<AudioSource>();
    }
    
    //When player dies the game over panel sets to active and pops up, allowing the player to click the buttons
    void Update()
    {
        //Ensures that the player is destroyed 
        if (GameObject.FindGameObjectWithTag("Player") == null && !GameManager.Instance.isGameOver) 
        {
            GameManager.Instance.GameOver(); //Game Manager script is set to Game Over
            gameOverPanel.SetActive(true); //Game over panel is shown
        }
    }

    //Restarts the Game
    public void Restart()
    {
        audioSource.PlayOneShot(buttonClickSound);
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Loads back to the game scene
    }

    //Goes back to main menu
    public void MainMenu()
    { 
        audioSource.PlayOneShot(buttonClickSound);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); //Loads back to main menu scene
    }
    
}
