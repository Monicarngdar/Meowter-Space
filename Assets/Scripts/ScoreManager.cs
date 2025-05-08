using UnityEngine;
using TMPro; 
public class ScoreManager : MonoBehaviour
{
    //Reference to the UI element
   public TextMeshProUGUI scoreText;
   
   //Value of score that increases overtime
   private float score;
    void Update()
    {
        //If the player GameObject still exist
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            
            //Increases the score by 1 and updates the UI 
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}
