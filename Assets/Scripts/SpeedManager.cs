using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    //speed increases as the game progresses
    public static SpeedManager Instance;
    
    public float gameSpeed; //Starting game speed
    public float speedIncrease; //To increase each time
    
    private float speedIncreaseInterval = 10f; //To increase per interval
    private float nextspeedIncrease = 0f; //next increase time
   
    private void Awake()
    {
        //Only stores the speed manager
        if (Instance == null)
        {
            Instance = this;
        }
        
    }

    void Start()
    {
        //set the time of speed increase
        nextspeedIncrease = Time.time + speedIncrease;
    }

     void Update()
    {
        //if the current speed increase has reached
        if (Time.time >= nextspeedIncrease)
            
        {
            //Makes the game go faster and next increase speed
            gameSpeed += speedIncrease;
            nextspeedIncrease = Time.time + speedIncreaseInterval;
        }
    }
    
}
