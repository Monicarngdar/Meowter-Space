using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    //speed increases as the game progresses
    public static SpeedManager Instance;
    
    public float gameSpeed;
    public float speedIncrease;

    private float speedIncreaseInterval = 10f;
    private float nextspeedIncrease = 0f;
   
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
    }

    void Start()
    {
        nextspeedIncrease = Time.time + speedIncrease;
    }

     void Update()
    {
        if (Time.time >= nextspeedIncrease)
            
        {
            gameSpeed += speedIncrease;
            nextspeedIncrease = Time.time + speedIncreaseInterval;
        }
    }
    
}
