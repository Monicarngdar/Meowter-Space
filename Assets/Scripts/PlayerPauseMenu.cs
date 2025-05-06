using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPauseMenu : MonoBehaviour
{
    //Reference to the UI element
 public GameObject pauseGamePanel;

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
       Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   //When the player clicks main menu, they go back to the main menu scene
   public void MainMenu()
   {
       Time.timeScale = 1f;
       SceneManager.LoadScene("MainMenu");
   }

}
