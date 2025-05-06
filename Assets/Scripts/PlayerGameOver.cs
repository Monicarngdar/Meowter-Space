using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
{
    //Add the game over screen panel
    public GameObject  gameOverPanel;
    
    public AudioClip gameOverSound;
    public AudioClip buttonClickSound;
    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    //When player dies the game over panel pops up
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
