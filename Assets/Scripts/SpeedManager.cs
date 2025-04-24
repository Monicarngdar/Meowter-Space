using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    //speed increases as the game progresses
    public static SpeedManager Instance;
    
    public float gameSpeed;
    public float speedIncrease;

    private float speedIncreaseInterval = 10f;
    private float intialSpeed;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        
    }

     void Update()
    {
        if (Time.time > intialSpeed)
        {
            gameSpeed += speedIncrease;
            intialSpeed = Time.time + speedIncreaseInterval;
        }
    }
    
}
