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
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    //Restarts the Game
    public void Restart()
    {
        audioSource.PlayOneShot(buttonClickSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Goes back to main menu
    public void MainMenu()
    { 
        audioSource.PlayOneShot(buttonClickSound);
        SceneManager.LoadScene("MainMenu");
    }
    
}
