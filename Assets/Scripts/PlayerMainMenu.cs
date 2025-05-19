using UnityEngine;
using UnityEngine.SceneManagement; //loads the scene

public class PlayerMainMenu : MonoBehaviour
{
   //When player clicks ''PLAY'' they get to choose a character and click ''START GAME'' to play the game
   public void PlayGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
