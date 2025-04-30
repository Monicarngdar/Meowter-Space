using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMainMenu : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
