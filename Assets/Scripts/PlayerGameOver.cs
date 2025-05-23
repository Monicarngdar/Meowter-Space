using UnityEngine;
using UnityEngine.SceneManagement; //Loads in the scene

public class PlayerGameOver : MonoBehaviour
{
   
    public GameObject  gameOverPanel;  //Add the game over screen panel
    public GameObject  pauseButton;  //Add the pause button game object
    public GameObject laserText; //Add the laser text game object
    
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

            if (pauseButton != null)  //Hides the pause button when player is game over
            {
                pauseButton.SetActive(false);
            }

            if (laserText != null) //Hides the laser text reloading when player is game over
            {
                laserText.SetActive(false);
            }
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
