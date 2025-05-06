using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
{
    //Add the game over screen panel
    public GameObject  gameOverPanel;
    
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Goes back to main menu
    public void MainMenu()
    {
       SceneManager.LoadScene("MainMenu");
    }
    
}
