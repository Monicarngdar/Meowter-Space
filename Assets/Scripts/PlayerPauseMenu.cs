using UnityEngine;
using UnityEngine.SceneManagement; //Loads in the scene

public class PlayerPauseMenu : MonoBehaviour
{
    //Reference to the UI element
    public GameObject pauseGamePanel;
 
   public AudioClip buttonUISound;
   private AudioSource audioSource;
 
   
   //Audio Variables
   void Start()
   {
       //Audio source component to be placed
       audioSource = GetComponent<AudioSource>();
   }
   
   
 //When game is paused, the panel shows upn and freezes the game
   public void PauseGame()
   {
       pauseGamePanel.SetActive(true);
       Time.timeScale = 0;
   }
  //When the player clicks resume, they can continue playing the game
   public void ResumeGame()
   {
       pauseGamePanel.SetActive(false);
       Time.timeScale = 1f;
   }
//When the player clicks restarts, it restarts the scene
   public void RestartGame()
   {
       if (buttonUISound != null)
       {
           audioSource.PlayOneShot(buttonUISound);
       }

       Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   //When the player clicks main menu, they go back to the main menu scene
   public void MainMenu()
   {
       if (buttonUISound != null)
       {
           audioSource.PlayOneShot(buttonUISound);
       }

       Time.timeScale = 1f;
       SceneManager.LoadScene("MainMenu");
   }

}
