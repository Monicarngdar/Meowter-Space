using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    
    public static SpeedManager Instance;
    
    public float gameSpeed = 1f;
    public float speedIncrease = 0.0005f;

    private float speedIncreaseInterval =50f;
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
