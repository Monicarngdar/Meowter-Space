using UnityEngine;
using UnityEngine.SceneManagement; //loads the scene

public class PlayerMainMenu : MonoBehaviour
{
   //When player clicks ''Start Game'' when they select their character the game scene is played
   public void PlayGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
