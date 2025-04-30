using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
{
    //Add the game over screen panel
    public GameObject  gameOverPanel;
    
   
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
